using System.Text;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Polly;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();

builder.Host.UseSerilog();

// Dodanie Ocelot
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot();

//Konfiguracja JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

// Dodanie kontrolerów
builder.Services.AddControllers();

// Dodanie Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dodanie Health Checks
builder.Services.AddHealthChecks()
    .AddUrlGroup(new Uri(builder.Configuration["Services:Identity"]), name: "identity-api", tags: new[] { "services" })
    .AddUrlGroup(new Uri(builder.Configuration["Services:AnimalManagement"]), name: "animal-management-api", tags: new[] { "services" })
    .AddUrlGroup(new Uri(builder.Configuration["Services:FieldManagement"]), name: "field-management-api", tags: new[] { "services" })
    .AddUrlGroup(new Uri(builder.Configuration["Services:EmployeeManagement"]), name: "employee-management-api", tags: new[] { "services" })
    .AddUrlGroup(new Uri(builder.Configuration["Services:MachineManagement"]), name: "machine-management-api", tags: new[] { "services" })
    .AddUrlGroup(new Uri(builder.Configuration["Services:NotificationService"]), name: "notification-service", tags: new[] { "services" });

// Konfiguracja HttpClient i odporności na błędy
builder.Services.AddHttpClient("AnimalServiceClient", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["Services:AnimalManagement"]);
})
.AddTransientHttpErrorPolicy(policy =>
    policy.WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))));


// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();

// Konfiguracja middlewarów
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

// Health Checks endpoints
app.MapHealthChecks("/health", new HealthCheckOptions
{
    Predicate = _ => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

app.MapHealthChecks("/health/services", new HealthCheckOptions
{
    Predicate = reg => reg.Tags.Contains("services"),
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

// Konfiguracja Ocelot
await app.UseOcelot();

app.Run();