using System;
using AnimalManagement.Domain.Entities;
using AnimalManagement.Domain.Enums;

namespace AnimalManagement.Domain.Events;

public class HealthRecordAddedDomainEvent : IDomainEvent
{
    public Guid Id { get; }
    public DateTime Timestamp { get; }
    public Guid AnimalId { get; }
    public Guid HealthRecordId { get; }
    public HealthRecordType RecordType { get; }
    public string Description { get; }

    public HealthRecordAddedDomainEvent(Animal animal, HealthRecord healthRecord)
    {
        Id = Guid.NewGuid();
        Timestamp = DateTime.UtcNow;
        AnimalId = animal.Id;
        HealthRecordId = healthRecord.Id;
        RecordType = healthRecord.Type;
        Description = healthRecord.Description;
    }
}
