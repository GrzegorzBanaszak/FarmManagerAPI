using System;

namespace AnimalManagement.Infrastructure.EventBus.IntegrationEvents;

public class FeedingReminderIntegrationEvent : IIntegrationEvent
{
    public Guid Id { get; private set; }
    public DateTime CreationDate { get; private set; }

    public Guid ScheduleId { get; private set; }
    public string ScheduleName { get; private set; }
    public DateTime FeedingTime { get; private set; }
    public Guid? AnimalId { get; private set; }
    public string AnimalName { get; private set; }
    public Guid? AnimalGroupId { get; private set; }
    public string AnimalGroupName { get; private set; }

    public FeedingReminderIntegrationEvent(
        Guid scheduleId,
        string scheduleName,
        DateTime feedingTime,
        Guid? animalId = null,
        string animalName = null,
        Guid? animalGroupId = null,
        string animalGroupName = null)
    {
        Id = Guid.NewGuid();
        CreationDate = DateTime.UtcNow;
        ScheduleId = scheduleId;
        ScheduleName = scheduleName;
        FeedingTime = feedingTime;
        AnimalId = animalId;
        AnimalName = animalName;
        AnimalGroupId = animalGroupId;
        AnimalGroupName = animalGroupName;
    }
}
