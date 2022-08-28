using Microsoft.Maui.Controls;
using milkdrunk.PageModels;
using milkdrunk.Pages;

namespace milkdrunk.PageModels;

class PumpingPageModel : BasePageModel
{
    public PumpingPageModel()
    {
        MyPumpingsCommand = new Command(MyPumpings);
    }

    public Command? MyPumpingsCommand { get; }

    async void MyPumpings()
    {
        IsBusy = true;
        await Shell.Current.Navigation.PushAsync(new MyPumpingsPage());
        IsBusy = false;
    }
}
