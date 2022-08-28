using Microsoft.Maui.Controls;
using milkdrunk.Models;
using milkdrunk.PageModels;

namespace milkdrunk.Pages;

partial class BabyDetailPage : ContentPage
{
    BabyDetailPageModel _pm;

    public BabyDetailPage(
        Baby baby)
    {
        BindingContext = _pm = new BabyDetailPageModel(baby);
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
