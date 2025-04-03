using System;

namespace AnimalManagement.Domain.Entities;

public class Medication
{
    public Guid Id { get; private set; }
    public Guid HealthRecordId { get; private set; }
    public HealthRecord HealthRecord { get; private set; }
    public string Name { get; private set; } // Nazwa leku
    public string Dosage { get; private set; } // Dawkowanie
    public DateTime AdministrationDate { get; private set; } // Data podania
    public DateTime? ExpiryDate { get; private set; } // Data ważności leku
    public string BatchNumber { get; private set; } // Numer partii
    public string Notes { get; private set; } // Dodatkowe notatki
    public int WithdrawalPeriodDays { get; private set; } // Okres karencji w dniach
    public DateTime? SafeAfterDate { get; private set; } // Data bezpiecznego wykorzystania produktów po podaniu leku

    // Konstruktor
    public Medication(string name, string dosage, DateTime administrationDate, string batchNumber, int withdrawalPeriodDays)
    {
        Id = Guid.NewGuid();
        Name = name;
        Dosage = dosage;
        AdministrationDate = administrationDate;
        BatchNumber = batchNumber;
        WithdrawalPeriodDays = withdrawalPeriodDays;

        if (withdrawalPeriodDays > 0)
        {
            SafeAfterDate = administrationDate.AddDays(withdrawalPeriodDays);
        }
    }
}
