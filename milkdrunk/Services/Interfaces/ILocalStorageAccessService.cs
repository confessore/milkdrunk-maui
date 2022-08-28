using System.Threading.Tasks;

namespace milkdrunk.Services.Interfaces;

public interface ILocalStorageAccessService
{
    Task<string> FilePathAsync(string filename);
    string FilePath(string filename);
}
