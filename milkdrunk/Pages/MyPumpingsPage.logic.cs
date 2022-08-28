using Microsoft.Maui.Controls;
using milkdrunk.PageModels;

namespace milkdrunk.Pages;

partial class MyPumpingsPage : ContentPage
{
    MyPumpingsPageModel _pm;

    public MyPumpingsPage()
    {
        BindingContext = _pm = new MyPumpingsPageModel();
        ToolbarItems.Add(NewPumpingToolbarItem());
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
