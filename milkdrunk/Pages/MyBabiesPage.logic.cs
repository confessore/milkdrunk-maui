using Microsoft.Maui.Controls;
using milkdrunk.PageModels;

namespace milkdrunk.Pages;

partial class MyBabiesPage : ContentPage
{
    MyBabiesPageModel _pm;

    public MyBabiesPage()
    {
        BindingContext = _pm = new MyBabiesPageModel();
        ToolbarItems.Add(NewBabyToolbarItem());
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
