using System;

namespace AnimalManagement.Domain.Entities;

public class WeightRecord
{
    public Guid Id { get; private set; }
    public Guid AnimalId { get; private set; }
    public Animal Animal { get; private set; }
    public DateTime MeasurementDate { get; private set; } // Data pomiaru
    public decimal Weight { get; private set; } // Waga
    public string MeasurementUnit { get; private set; } // Jednostka miary (kg)
    public Guid EmployeeId { get; private set; } // Identyfikator pracownika
    public string EmployeeName { get; private set; } // Imię i nazwisko pracownika
    public string Notes { get; private set; } // Dodatkowe notatki

    // Konstruktor
    public WeightRecord(decimal weight, string measurementUnit, DateTime measurementDate,
        Guid employeeId, string employeeName, string notes = null)
    {
        Id = Guid.NewGuid();
        Weight = weight;
        MeasurementUnit = measurementUnit;
        MeasurementDate = measurementDate;
        EmployeeId = employeeId;
        EmployeeName = employeeName;
        Notes = notes;
    }
}
