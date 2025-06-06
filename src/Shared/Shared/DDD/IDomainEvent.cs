using MediatR;

namespace Shared.DDD;

public interface IDomainEvent : INotification
{
    Guid Id => Guid.NewGuid();
    public DateTime DateOccurred => DateTime.UtcNow;
    public string EventName => GetType().AssemblyQualifiedName;
}
