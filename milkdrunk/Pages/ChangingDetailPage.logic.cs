using Microsoft.Maui.Controls;
using milkdrunk.Models;
using milkdrunk.PageModels;

namespace milkdrunk.Pages;

partial class ChangingDetailPage : ContentPage
{
    ChangingDetailPageModel _pm;

    public ChangingDetailPage(
        Changing changing)
    {
        BindingContext = _pm = new ChangingDetailPageModel(changing);
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
