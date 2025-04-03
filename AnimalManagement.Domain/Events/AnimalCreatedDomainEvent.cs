using System;
using AnimalManagement.Domain.Entities;

namespace AnimalManagement.Domain.Events;

public class AnimalCreatedDomainEvent : IDomainEvent
{
    public Guid Id { get; }
    public DateTime Timestamp { get; }
    public Guid AnimalId { get; }
    public string AnimalName { get; }
    public string Species { get; }
    public string IdentificationNumber { get; }

    public AnimalCreatedDomainEvent(Animal animal)
    {
        Id = Guid.NewGuid();
        Timestamp = DateTime.UtcNow;
        AnimalId = animal.Id;
        AnimalName = animal.Name;
        Species = animal.Species;
        IdentificationNumber = animal.IdentificationNumber;
    }
}
