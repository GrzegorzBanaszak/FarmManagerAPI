using System;
using AnimalManagement.Domain.Entities;

namespace AnimalManagement.Domain.Events;

public class FeedingScheduleCreatedDomainEvent : IDomainEvent
{
    public Guid Id { get; }
    public DateTime Timestamp { get; }
    public Guid ScheduleId { get; }
    public Guid? AnimalId { get; }
    public Guid? AnimalGroupId { get; }
    public string ScheduleName { get; }

    public FeedingScheduleCreatedDomainEvent(FeedingSchedule schedule)
    {
        Id = Guid.NewGuid();
        Timestamp = DateTime.UtcNow;
        ScheduleId = schedule.Id;
        AnimalId = schedule.AnimalId;
        AnimalGroupId = schedule.AnimalGroupId;
        ScheduleName = schedule.Name;
    }
}
