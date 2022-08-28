using milkdrunk.Models;
using System.Threading.Tasks;

namespace milkdrunk.Services.Interfaces;

public interface IDefaultService
{
    Caregiver? Caregiver { get; set; }

    Caregroup? Caregroup { get; set; }

    Baby? Baby { get; set; }

    string? Title { get; set; }

    Task UpdatePropertiesAsync();
}
