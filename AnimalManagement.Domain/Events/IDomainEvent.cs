using System;

namespace AnimalManagement.Domain.Events;

public interface IDomainEvent
{
    Guid Id { get; }
    DateTime Timestamp { get; }
}
