using System;

namespace AnimalManagement.Infrastructure.EventBus.IntegrationEvents;

public class AnimalCreatedIntegrationEvent : IIntegrationEvent
{
    public Guid Id { get; private set; }
    public DateTime CreationDate { get; private set; }

    public Guid AnimalId { get; private set; }
    public string Name { get; private set; }
    public string Species { get; private set; }
    public string IdentificationNumber { get; private set; }

    public AnimalCreatedIntegrationEvent(Guid animalId, string name, string species, string identificationNumber)
    {
        Id = Guid.NewGuid();
        CreationDate = DateTime.UtcNow;
        AnimalId = animalId;
        Name = name;
        Species = species;
        IdentificationNumber = identificationNumber;
    }
}
