using Microsoft.Maui.Controls;
using milkdrunk.PageModels;

namespace milkdrunk.Pages;

partial class NewChangingPage : ContentPage
{
    NewChangingPageModel _pm;

    public NewChangingPage()
    {
        BindingContext = _pm = new NewChangingPageModel();
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
