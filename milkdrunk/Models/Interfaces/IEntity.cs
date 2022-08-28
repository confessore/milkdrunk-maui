using System;

namespace milkdrunk.Models.Interfaces;

public interface IEntity<T>
    where T : IEquatable<T>
{
    T? Id { get; set; }
    long? CreatedAt { get; set; }
}
