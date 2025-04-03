using System;

namespace AnimalManagement.Domain.Entities;

public class FeedType
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } // Nazwa karmy
    public string Description { get; private set; } // Opis
    public string Manufacturer { get; private set; } // Producent
    public string NutritionalInfo { get; private set; } // Informacje o wartościach odżywczych
    public decimal PricePerUnit { get; private set; } // Cena za jednostkę
    public string MeasurementUnit { get; private set; } // Jednostka miary
    public bool IsActive { get; private set; } // Czy karma jest aktywna
    public string StorageInstructions { get; private set; } // Instrukcje przechowywania
    public string Notes { get; private set; } // Dodatkowe notatki

    // Konstruktor
    public FeedType(string name, string description, string manufacturer, string measurementUnit, decimal pricePerUnit)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Manufacturer = manufacturer;
        MeasurementUnit = measurementUnit;
        PricePerUnit = pricePerUnit;
        IsActive = true;
    }

    // Metody biznesowe
    public void UpdatePrice(decimal newPrice)
    {
        PricePerUnit = newPrice;
    }

    public void Deactivate()
    {
        IsActive = false;
    }

    public void Activate()
    {
        IsActive = true;
    }
}
