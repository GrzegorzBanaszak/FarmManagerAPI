using System;
using AnimalManagement.Domain.Enums;
using AnimalManagement.Domain.Events;

namespace AnimalManagement.Domain.Entities;

public class FeedingSchedule
{
    public Guid Id { get; private set; }
    public Guid? AnimalId { get; private set; }
    public Animal Animal { get; private set; }
    public Guid? AnimalGroupId { get; private set; }
    public AnimalGroup AnimalGroup { get; private set; }
    public string Name { get; private set; } // Nazwa harmonogramu
    public FeedingFrequency Frequency { get; private set; } // Częstotliwość (enum: dziennie, co drugi dzień, tygodniowo)
    public TimeSpan FeedingTime { get; private set; } // Godzina karmienia
    public bool IsActive { get; private set; } // Czy harmonogram jest aktywny
    public DateTime StartDate { get; private set; } // Data rozpoczęcia
    public DateTime? EndDate { get; private set; } // Data zakończenia
    public string Notes { get; private set; } // Dodatkowe notatki

    // Relacje
    public ICollection<FeedingScheduleItem> FeedItems { get; private set; } = new List<FeedingScheduleItem>();
    public ICollection<FeedingRecord> FeedingRecords { get; private set; } = new List<FeedingRecord>();

    private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    // Metody biznesowe
    public void AddFeedItem(FeedType feedType, decimal quantity, string instructions) { /* ... */ }
    public void RecordFeeding(DateTime date, string notes) { /* ... */ }
    public void DeactivateSchedule() { /* ... */ }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}
