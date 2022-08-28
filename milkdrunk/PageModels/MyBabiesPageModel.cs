using Microsoft.Maui.Controls;
using milkdrunk.Extensions;
using milkdrunk.Models;
using milkdrunk.Pages;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace milkdrunk.PageModels;

class MyBabiesPageModel : BasePageModel
{
    public MyBabiesPageModel()
    {
        NewBabyCommand = new Command(NewBaby);
    }

    ObservableCollection<Baby>? babies;
    public ObservableCollection<Baby>? Babies
    {
        get => babies;
        set
        {
            babies = value;
            OnPropertyChanged();
        }
    }

    Baby? selectedBaby;
    public Baby? SelectedBaby
    {
        get => selectedBaby;
        set
        {
            selectedBaby = value;
            OnPropertyChanged();
        }
    }

    public Command? NewBabyCommand { get; }

    async void NewBaby()
    {
        IsBusy = true;
        await Shell.Current.Navigation.PushAsync(new NewBabyPage());
        IsBusy = false;
    }

    public async void OnBabySelectionChanged(object sender, SelectionChangedEventArgs args)
    {
        IsBusy = true;
        await Shell.Current.Navigation.PushAsync(new BabyDetailPage(SelectedBaby ?? new Baby()));
        IsBusy = false;
    }

    public override async Task OnAppearingAsync()
    {
        await base.OnAppearingAsync();
        IsBusy = true;
        if (Caregiver != null)
        {
            if (Caregiver.Babies != null)
                Babies = Caregiver.Babies.ToObservableCollection();
        }
        IsBusy = false;
    }
}
