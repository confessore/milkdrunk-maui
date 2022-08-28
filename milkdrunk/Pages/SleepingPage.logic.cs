using Microsoft.Maui.Controls;
using milkdrunk.PageModels;

namespace milkdrunk.Pages;

partial class SleepingPage : ContentPage
{
    SleepingPageModel _pm;

    public SleepingPage()
    {
        BindingContext = _pm = new SleepingPageModel();
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
