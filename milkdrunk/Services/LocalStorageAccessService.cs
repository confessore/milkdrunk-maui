using Microsoft.Maui.Storage;
using milkdrunk.Services.Interfaces;
using System.IO;
using System.Threading.Tasks;

namespace milkdrunk.Services
{
    public class LocalStorageAccessService : ILocalStorageAccessService
    {
        public Task<string> FilePathAsync(string filename) =>
            Task.FromResult(Path.Combine(FileSystem.AppDataDirectory, filename));

        public string FilePath(string filename) =>
            FilePathAsync(filename).Result;
    }
}
