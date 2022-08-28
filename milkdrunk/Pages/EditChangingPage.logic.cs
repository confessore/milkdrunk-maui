using milkdrunk.Models;
using milkdrunk.PageModels;
using Microsoft.Maui.Controls;

namespace milkdrunk.Pages;

partial class EditChangingPage : ContentPage
{
    EditChangingPageModel _pm;

    public EditChangingPage(
        Changing changing)
    {
        BindingContext = _pm = new EditChangingPageModel(changing);
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
