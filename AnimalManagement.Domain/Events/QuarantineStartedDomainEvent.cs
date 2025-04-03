using System;
using AnimalManagement.Domain.Entities;

namespace AnimalManagement.Domain.Events;

public class QuarantineStartedDomainEvent : IDomainEvent
{

    public Guid Id { get; }
    public DateTime Timestamp { get; }
    public Guid AnimalId { get; }
    public Guid QuarantineId { get; }
    public string Reason { get; }
    public DateTime StartDate { get; }

    public QuarantineStartedDomainEvent(Animal animal, Quarantine quarantine)
    {
        Id = Guid.NewGuid();
        Timestamp = DateTime.UtcNow;
        AnimalId = animal.Id;
        QuarantineId = quarantine.Id;
        Reason = quarantine.Reason;
        StartDate = quarantine.StartDate;
    }
}
