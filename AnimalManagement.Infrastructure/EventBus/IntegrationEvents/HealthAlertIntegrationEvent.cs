using System;

namespace AnimalManagement.Infrastructure.EventBus.IntegrationEvents;

public class HealthAlertIntegrationEvent : IIntegrationEvent
{
    public Guid Id { get; private set; }
    public DateTime CreationDate { get; private set; }

    public Guid AnimalId { get; private set; }
    public string AnimalName { get; private set; }
    public string AlertType { get; private set; }
    public string Description { get; private set; }
    public string Severity { get; private set; }

    public HealthAlertIntegrationEvent(Guid animalId, string animalName, string alertType, string description, string severity)
    {
        Id = Guid.NewGuid();
        CreationDate = DateTime.UtcNow;
        AnimalId = animalId;
        AnimalName = animalName;
        AlertType = alertType;
        Description = description;
        Severity = severity;
    }
}
