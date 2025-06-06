using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DDD;

public class Aggregate<TId> : Entity<TId>, IAggregate<TId>
{
    private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
    public IReadOnlyList<IDomainEvent> Events => _domainEvents.AsReadOnly();

    public IDomainEvent[] ClearDomainEvents()
    {
        var domainEvents = _domainEvents.ToArray();
        _domainEvents.Clear();
        return domainEvents;
    }

    public void AddDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);
}
