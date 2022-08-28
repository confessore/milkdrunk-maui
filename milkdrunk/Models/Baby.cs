using milkdrunk.Models.Abstractions;
using System;
using System.Collections.Generic;

namespace milkdrunk.Models;

public class Baby : Entity<string>
{
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
    public virtual ICollection<Changing>? Changings { get; set; }
    public virtual ICollection<Feeding>? Feedings { get; set; }
    public virtual ICollection<Sleeping>? Sleepings { get; set; }
}
