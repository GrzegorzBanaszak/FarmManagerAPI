using System;

namespace AnimalManagement.Domain.Entities;

public class FeedingScheduleItem
{
    public Guid Id { get; private set; }
    public Guid FeedingScheduleId { get; private set; }
    public FeedingSchedule FeedingSchedule { get; private set; }
    public Guid FeedTypeId { get; private set; }
    public FeedType FeedType { get; private set; }
    public decimal Quantity { get; private set; } // Ilość
    public string MeasurementUnit { get; private set; } // Jednostka miary (kg, l, itp.)
    public string Instructions { get; private set; } // Instrukcje podawania
    public int SequenceOrder { get; private set; } // Kolejność podawania

    // Konstruktor
    public FeedingScheduleItem(Guid feedTypeId, decimal quantity, string measurementUnit, string instructions, int sequenceOrder)
    {
        Id = Guid.NewGuid();
        FeedTypeId = feedTypeId;
        Quantity = quantity;
        MeasurementUnit = measurementUnit;
        Instructions = instructions;
        SequenceOrder = sequenceOrder;
    }

    // Metody biznesowe
    public void UpdateQuantity(decimal newQuantity)
    {
        Quantity = newQuantity;
    }
}
