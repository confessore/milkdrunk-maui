using milkdrunk.Models.Abstractions;
using milkdrunk.Models.Enums;
using System;

namespace milkdrunk.Models;

public class Changing : Entity<string>
{
    public ChangingType ChangingType { get; set; }
    public DateTime Time { get; set; }
}
