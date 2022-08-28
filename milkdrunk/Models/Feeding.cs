using milkdrunk.Models.Abstractions;
using milkdrunk.Models.Enums;
using System;

namespace milkdrunk.Models;

public class Feeding : Entity<string>
{
    public FeedingType FeedingType { get; set; }
    public DateTime Time { get; set; }
    public double FluidOunces { get; set; }
}
