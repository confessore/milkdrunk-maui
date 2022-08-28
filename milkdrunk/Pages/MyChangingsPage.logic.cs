using Microsoft.Maui.Controls;
using milkdrunk.PageModels;

namespace milkdrunk.Pages;

partial class MyChangingsPage : ContentPage
{
    MyChangingsPageModel _pm;

    public MyChangingsPage()
    {
        BindingContext = _pm = new MyChangingsPageModel();
        ToolbarItems.Add(NewChangingToolbarItem());
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
