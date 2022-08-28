using Microsoft.Maui.Controls;
using milkdrunk.Models;
using milkdrunk.Services;
using milkdrunk.Services.Interfaces;
using System.Threading.Tasks;

namespace milkdrunk;

public partial class App : Application
{
    public App()
    {
        RegisterServices();
        Build();
    }

    protected override async void OnStart()
    {
        
    }

    protected override void OnSleep()
    {
    }

    protected override void OnResume()
    {
    }

    void RegisterServices()
    {
        DependencyService.Register<ILocalStorageAccessService, LocalStorageAccessService>();
        DependencyService.Register<ILiteDBService<Caregiver, string>, LiteDBService<Caregiver, string>>();
        DependencyService.Register<IDefaultService, DefaultService>();
        DependencyService.Register<ILocalStorageService, LocalStorageService>();
    }
}
