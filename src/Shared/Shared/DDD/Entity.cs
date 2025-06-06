
namespace Shared.DDD;

public class Entity : IEntity
{
    public string CreatedBy { get; set ; }
    public string UpdatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public abstract class Entity<T> : IEntity<T>
{
    public T Id { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
