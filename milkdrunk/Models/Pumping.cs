using milkdrunk.Models.Abstractions;
using System;

namespace milkdrunk.Models;

public class Pumping : Entity<string>
{
    public DateTime Time { get; set; }
    public double FluidOunces { get; set; }
}
