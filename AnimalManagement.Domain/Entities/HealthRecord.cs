using System;
using AnimalManagement.Domain.Enums;
using AnimalManagement.Domain.Events;

namespace AnimalManagement.Domain.Entities;

public class HealthRecord
{
    public Guid Id { get; private set; }
    public Guid AnimalId { get; private set; }
    public Animal Animal { get; private set; }
    public DateTime Date { get; private set; }
    public HealthRecordType Type { get; private set; } // Typ zdarzenia (enum: badanie, choroba, szczepienie, leczenie)
    public string Description { get; private set; } // Opis zdarzenia
    public string Diagnosis { get; private set; } // Diagnoza (jeśli dotyczy)
    public string TreatmentDescription { get; private set; } // Opis leczenia
    public string Medication { get; private set; } // Zastosowane leki
    public string Dosage { get; private set; } // Dawkowanie leków
    public decimal Temperature { get; private set; } // Temperatura ciała
    public Guid VeterinarianId { get; private set; } // Identyfikator lekarza weterynarii
    public string VeterinarianName { get; private set; } // Imię i nazwisko lekarza weterynarii
    public decimal Cost { get; private set; } // Koszt leczenia
    public DateTime? NextCheckupDate { get; private set; } // Data kolejnego badania
    public string Notes { get; private set; } // Dodatkowe notatki
    public byte[] Attachment { get; private set; } // Załącznik (np. wyniki badań)

    // Relacje
    public ICollection<Medication> Medications { get; private set; } = new List<Medication>();

    private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    // Metody biznesowe
    public void UpdateDetails(string description, string diagnosis, string treatment) { /* ... */ }
    public void ScheduleFollowUp(DateTime nextCheckupDate) { /* ... */ }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

}
