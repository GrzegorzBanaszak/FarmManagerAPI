using System;
using AnimalManagement.Domain.Enums;
using AnimalManagement.Domain.Events;

namespace AnimalManagement.Domain.Entities;

public class Quarantine
{
    public Guid Id { get; private set; }
    public Guid AnimalId { get; private set; }
    public Animal Animal { get; private set; }
    public DateTime StartDate { get; private set; } // Data rozpoczęcia
    public DateTime? EndDate { get; private set; } // Data zakończenia
    public string Reason { get; private set; } // Powód kwarantanny
    public string Location { get; private set; } // Miejsce kwarantanny
    public string Instructions { get; private set; } // Instrukcje postępowania
    public QuarantineStatus Status { get; private set; } // Status (enum: aktywna, zakończona)
    public Guid? VeterinarianId { get; private set; } // Identyfikator lekarza weterynarii
    public string VeterinarianName { get; private set; } // Imię i nazwisko lekarza weterynarii
    public string Notes { get; private set; } // Dodatkowe notatki

    private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    // Metody biznesowe
    public void EndQuarantine(DateTime endDate, string notes) { /* ... */ }
    public void ExtendQuarantine(DateTime newEndDate, string reason) { /* ... */ }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}
