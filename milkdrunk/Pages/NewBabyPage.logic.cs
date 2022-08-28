using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using milkdrunk.PageModels;

namespace milkdrunk.Pages;

partial class NewBabyPage : ContentPage
{
    NewBabyPageModel _pm;

    public NewBabyPage()
    {
        On<Microsoft.Maui.Controls.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        BindingContext = _pm = new NewBabyPageModel();
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
