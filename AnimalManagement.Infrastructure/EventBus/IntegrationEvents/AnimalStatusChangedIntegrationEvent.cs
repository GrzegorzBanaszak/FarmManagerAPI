using System;

namespace AnimalManagement.Infrastructure.EventBus.IntegrationEvents;

public class AnimalStatusChangedIntegrationEvent : IIntegrationEvent
{
    public Guid Id { get; private set; }
    public DateTime CreationDate { get; private set; }

    public Guid AnimalId { get; private set; }
    public string Name { get; private set; }
    public string Status { get; private set; }
    public string Reason { get; private set; }

    public AnimalStatusChangedIntegrationEvent(Guid animalId, string name, string status, string reason)
    {
        Id = Guid.NewGuid();
        CreationDate = DateTime.UtcNow;
        AnimalId = animalId;
        Name = name;
        Status = status;
        Reason = reason;
    }
}
