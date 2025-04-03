using System;
using AnimalManagement.Domain.Enums;
using AnimalManagement.Domain.Events;

namespace AnimalManagement.Domain.Entities;

public class ReproductionRecord
{
    public Guid Id { get; private set; }
    public Guid AnimalId { get; private set; }
    public Animal Animal { get; private set; }
    public ReproductionEventType Type { get; private set; } // Typ zdarzenia (enum: ciąża, poród, ruja, inseminacja)
    public DateTime Date { get; private set; } // Data zdarzenia
    public DateTime? ExpectedEndDate { get; private set; } // Oczekiwana data zakończenia (np. porodu)
    public DateTime? ActualEndDate { get; private set; } // Faktyczna data zakończenia
    public Guid? FatherAnimalId { get; private set; } // Identyfikator ojca
    public string FatherInfo { get; private set; } // Informacje o ojcu (jeśli zewnętrzny)
    public int OffspringCount { get; private set; } // Liczba potomstwa
    public string Notes { get; private set; } // Dodatkowe notatki

    // Relacje
    public ICollection<Animal> Offspring { get; private set; } = new List<Animal>();

    private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    // Metody biznesowe
    public void RecordOutcome(DateTime endDate, int offspringCount) { /* ... */ }
    public void AddOffspring(Animal offspring) { /* ... */ }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}
