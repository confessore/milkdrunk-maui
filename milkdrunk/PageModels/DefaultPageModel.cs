using milkdrunk.Models;
using milkdrunk.Pages;
using milkdrunk.Shells;
using System.Linq;
using System.Threading.Tasks;

namespace milkdrunk.PageModels;

class DefaultPageModel : BasePageModel
{
    new public virtual async Task OnAppearingAsync()
    {
        IsBusy = true;
        System.Diagnostics.Debug.WriteLine("default page finding caregivers...");
        var caregivers = await _caregiverDBService.FindAllAsync();
        var caregiver = caregivers.FirstOrDefault();
        //var caregiver = await _localStorageService.ReadFromFileAsync<Caregiver>("caregiver");
        if (caregiver != null)
        {
            await Task.Delay(1000);
            App.Current.MainPage = new DefaultShell();
        }
        else
            App.Current.MainPage = new WelcomePage();
        IsBusy = false;
    }
}
