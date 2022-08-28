using Microsoft.Maui.Controls;
using milkdrunk.PageModels;

namespace milkdrunk.Pages;

partial class NewSleepingPage : ContentPage
{
    NewSleepingPageModel _pm;

    public NewSleepingPage()
    {
        BindingContext = _pm = new NewSleepingPageModel();
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
