using Microsoft.Maui.Controls;
using milkdrunk.PageModels;

namespace milkdrunk.Pages;

partial class MySleepingsPage : ContentPage
{
    MySleepingsPageModel _pm;

    public MySleepingsPage()
    {
        BindingContext = _pm = new MySleepingsPageModel();
        ToolbarItems.Add(NewSleepingToolbarItem());
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
