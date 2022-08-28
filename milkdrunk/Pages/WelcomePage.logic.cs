using milkdrunk.PageModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace milkdrunk.Pages;

partial class WelcomePage : ContentPage
{
    WelcomePageModel _pm;

    public WelcomePage()
    {
        On<Microsoft.Maui.Controls.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        BindingContext = _pm = new();
        Build();
    }
}
