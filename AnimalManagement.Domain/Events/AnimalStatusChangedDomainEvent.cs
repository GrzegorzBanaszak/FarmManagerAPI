using System;
using AnimalManagement.Domain.Entities;
using AnimalManagement.Domain.Enums;

namespace AnimalManagement.Domain.Events;

public class AnimalStatusChangedDomainEvent : IDomainEvent
{
    public Guid Id { get; }
    public DateTime Timestamp { get; }
    public Guid AnimalId { get; }
    public string AnimalName { get; }
    public AnimalStatus OldStatus { get; }
    public AnimalStatus NewStatus { get; }
    public string Reason { get; }

    public AnimalStatusChangedDomainEvent(Animal animal, AnimalStatus oldStatus, AnimalStatus newStatus, string reason)
    {
        Id = Guid.NewGuid();
        Timestamp = DateTime.UtcNow;
        AnimalId = animal.Id;
        AnimalName = animal.Name;
        OldStatus = oldStatus;
        NewStatus = newStatus;
        Reason = reason;
    }
}
