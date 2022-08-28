using milkdrunk.Models.Abstractions;
using milkdrunk.Models.Interfaces;
using System.Collections.Generic;

namespace milkdrunk.Models;

public class Caregroup : Entity<string>, IEntity<string>
{
    public virtual string? OwnerId { get; set; }
    public virtual ICollection<string>? MemberIds { get; set; }
}
