using milkdrunk.Models.Interfaces;
using System;

namespace milkdrunk.Models.Abstractions;

public abstract class Entity<T> : IEntity<T>
    where T : IEquatable<T>
{
    public T? Id { get; set; }
    public long? CreatedAt { get; set; }
}
