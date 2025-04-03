using System;
using AnimalManagement.Domain.Enums;
using AnimalManagement.Domain.Events;

namespace AnimalManagement.Domain.Entities;

public class AnimalGroup
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } // Nazwa grupy
    public string Description { get; private set; } // Opis
    public AnimalGroupType Type { get; private set; } // Typ grupy (enum: stado, zagroda, itp.)
    public string Location { get; private set; } // Lokalizacja w gospodarstwie
    public bool IsActive { get; private set; } // Czy grupa jest aktywna
    public DateTime CreationDate { get; private set; } // Data utworzenia
    public string Notes { get; private set; } // Dodatkowe notatki

    // Relacje
    public ICollection<Animal> Animals { get; private set; } = new List<Animal>();
    public ICollection<FeedingSchedule> FeedingSchedules { get; private set; } = new List<FeedingSchedule>();

    private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    // Metody biznesowe
    public void AddAnimal(Animal animal) { /* ... */ }
    public void RemoveAnimal(Animal animal) { /* ... */ }
    public void DeactivateGroup() { /* ... */ }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}
