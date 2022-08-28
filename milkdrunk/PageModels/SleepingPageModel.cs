using Microsoft.Maui.Controls;
using milkdrunk.Pages;

namespace milkdrunk.PageModels
{
    class SleepingPageModel : BasePageModel
    {
        public SleepingPageModel()
        {
            MySleepingsCommand = new Command(MySleepings);
        }

        public Command? MySleepingsCommand { get; }

        async void MySleepings()
        {
            IsBusy = true;
            await Shell.Current.Navigation.PushAsync(new MySleepingsPage());
            IsBusy = false;
        }
    }
}
