using milkdrunk.Models.Abstractions;
using System;

namespace milkdrunk.Models;

public class Sleeping : Entity<string>
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}
