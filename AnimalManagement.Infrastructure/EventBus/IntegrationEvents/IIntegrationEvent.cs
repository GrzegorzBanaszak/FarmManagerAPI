using System;

namespace AnimalManagement.Infrastructure.EventBus.IntegrationEvents;

public interface IIntegrationEvent
{
    Guid Id { get; }
    DateTime CreationDate { get; }
}
