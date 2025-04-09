FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ApiGateways/Web.BFF/Web.BFF.csproj", "ApiGateways/Web.BFF/"]
RUN dotnet restore "ApiGateways/Web.BFF/Web.BFF.csproj"
COPY . .
WORKDIR "/src/ApiGateways/Web.BFF"
RUN dotnet build "Web.BFF.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Web.BFF.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Web.BFF.dll"]