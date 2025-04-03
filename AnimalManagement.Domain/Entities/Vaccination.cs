using System;

namespace AnimalManagement.Domain.Entities;

public class Vaccination
{
    public Guid Id { get; private set; }
    public Guid AnimalId { get; private set; }
    public Animal Animal { get; private set; }
    public string VaccineName { get; private set; } // Nazwa szczepionki
    public string BatchNumber { get; private set; } // Numer partii
    public DateTime AdministrationDate { get; private set; } // Data podania
    public DateTime? ExpiryDate { get; private set; } // Data ważności szczepionki
    public DateTime? BoosterDate { get; private set; } // Data kolejnej dawki
    public Guid VeterinarianId { get; private set; } // Identyfikator lekarza weterynarii
    public string VeterinarianName { get; private set; } // Imię i nazwisko lekarza weterynarii
    public string Notes { get; private set; } // Dodatkowe notatki

    // Konstruktor
    public Vaccination(string vaccineName, string batchNumber, DateTime administrationDate,
        Guid veterinarianId, string veterinarianName)
    {
        Id = Guid.NewGuid();
        VaccineName = vaccineName;
        BatchNumber = batchNumber;
        AdministrationDate = administrationDate;
        VeterinarianId = veterinarianId;
        VeterinarianName = veterinarianName;
    }

    // Metody biznesowe
    public void ScheduleBooster(DateTime boosterDate)
    {
        BoosterDate = boosterDate;
    }
}
