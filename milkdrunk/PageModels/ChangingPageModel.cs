using Microsoft.Maui.Controls;
using milkdrunk.Models;
using milkdrunk.Pages;
using System.Collections.ObjectModel;

namespace milkdrunk.PageModels;

class ChangingPageModel : BasePageModel
{
    public ChangingPageModel()
    {
        MyChangingsCommand = new Command(MyChangings);
    }

    Changing? changing;
    public Changing? Changing
    {
        get => changing;
        set
        {
            changing = value;
            OnPropertyChanged();
        }
    }

    ObservableCollection<Changing>? changings;
    public ObservableCollection<Changing>? Changings
    {
        get => changings;
        set
        {
            changings = value;
            OnPropertyChanged();
        }
    }

    public Command? MyChangingsCommand { get; }

    async void MyChangings()
    {
        IsBusy = true;
        await Shell.Current.Navigation.PushAsync(new MyChangingsPage());
        IsBusy = false;
    }
}
