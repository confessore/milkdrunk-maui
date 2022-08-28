using Microsoft.Maui.Controls;
using milkdrunk.PageModels;

namespace milkdrunk.Pages;

partial class MyFeedingsPage : ContentPage
{
    MyFeedingsPageModel _pm;

    public MyFeedingsPage()
    {
        BindingContext = _pm = new MyFeedingsPageModel();
        ToolbarItems.Add(NewFeedingToolbarItem());
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
