using milkdrunk.Models.Abstractions;
using milkdrunk.Models.Interfaces;
using System.Collections.Generic;

namespace milkdrunk.Models;

public class Caregiver : Entity<string>, IEntity<string>
{
    public string? Name { get; set; }
    public string? ActiveBabyId { get; set; }
    public virtual ICollection<Baby>? Babies { get; set; }
    public string? CaregroupId { get; set; }
}
