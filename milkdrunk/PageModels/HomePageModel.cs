using Microsoft.Maui.Controls;
using milkdrunk.Models;
using milkdrunk.Pages;
using System;
using System.Threading.Tasks;

namespace milkdrunk.PageModels;

class HomePageModel : BasePageModel
{
    public HomePageModel()
    {
        System.Diagnostics.Debug.WriteLine("home page..");
        MyBabiesCommand = new Command(MyBabies);
        CreateCaregroupCommand = new Command(CreateCaregroupAsync);
    }

    string? greeting = string.Empty;
    public string? Greeting
    {
        get => greeting;
        set
        {
            greeting = value;
            OnPropertyChanged();
        }
    }

    string? name = string.Empty;
    public string? Name
    {
        get => name;
        set
        {
            name = value;
            Greeting = $"welcome, {name}!";
            OnPropertyChanged();
        }
    }

    public Command? CreateCaregroupCommand { get; }

    async void CreateCaregroupAsync()
    {
        IsBusy = true;
        var caregroup = new Caregroup()
        {
            Id = Guid.NewGuid().ToString(),
            OwnerId = Caregiver.Id
        };
        //await _defaultService._caregroupContext.UpsertAsync(caregroup);
        var updated = new HomePage();
        await Shell.Current.Navigation.PopAsync();
        await Shell.Current.Navigation.PushAsync(updated);
        IsBusy = false;
    }

    public Command? MyBabiesCommand { get; }

    async void MyBabies()
    {
        IsBusy = true;
        await Shell.Current.Navigation.PushAsync(new MyBabiesPage());
        IsBusy = false;
    }

    public override async Task OnAppearingAsync()
    {
        await base.OnAppearingAsync();
        IsBusy = true;
        if (Caregiver != null)
            Name = Caregiver.Name;
        IsBusy = false;
    }
}
