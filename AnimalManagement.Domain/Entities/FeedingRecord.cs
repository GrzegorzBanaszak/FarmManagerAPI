using System;

namespace AnimalManagement.Domain.Entities;

public class FeedingRecord
{
    public Guid Id { get; private set; }
    public Guid FeedingScheduleId { get; private set; }
    public FeedingSchedule FeedingSchedule { get; private set; }
    public DateTime FeedingDate { get; private set; } // Data karmienia
    public Guid EmployeeId { get; private set; } // Identyfikator pracownika
    public string EmployeeName { get; private set; } // Imię i nazwisko pracownika
    public string Notes { get; private set; } // Dodatkowe notatki
    public bool WasEaten { get; private set; } // Czy karma została zjedzona
    public string FeedbackNotes { get; private set; } // Notatki dotyczące reakcji na karmę

    // Konstruktor
    public FeedingRecord(DateTime feedingDate, Guid employeeId, string employeeName)
    {
        Id = Guid.NewGuid();
        FeedingDate = feedingDate;
        EmployeeId = employeeId;
        EmployeeName = employeeName;
        WasEaten = true; // Domyślnie zakładamy, że karma została zjedzona
    }

    // Metody biznesowe
    public void SetFeedbackNotes(bool wasEaten, string feedbackNotes)
    {
        WasEaten = wasEaten;
        FeedbackNotes = feedbackNotes;
    }
}
