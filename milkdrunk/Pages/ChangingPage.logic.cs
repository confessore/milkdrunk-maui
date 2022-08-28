using Microsoft.Maui.Controls;
using milkdrunk.PageModels;

namespace milkdrunk.Pages;

partial class ChangingPage : ContentPage
{
    ChangingPageModel _pm;

    public ChangingPage()
    {
        BindingContext = _pm = new ChangingPageModel();
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
