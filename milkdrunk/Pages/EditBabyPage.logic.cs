using milkdrunk.PageModels;
using Microsoft.Maui.Controls;

namespace milkdrunk.Pages;

partial class EditBabyPage : ContentPage
{
    EditBabyPageModel _pm;

    public EditBabyPage()
    {
        BindingContext = _pm = new EditBabyPageModel();
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
