using Microsoft.Maui;
using milkdrunk.Controls;
#if IOS
using PlatformView = milkdrunk.Platforms.iOS.Controls.MauiAd;
#elif MACCATALYST
using PlatformView = milkdrunk.Platforms.MacCatalyst.Controls.MauiAd;
#elif ANDROID
using PlatformView = milkdrunk.Platforms.Android.Controls.MauiAd;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.FrameworkElement;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0 && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif

namespace milkdrunk.Handlers;

public partial class AdHandler
{
    public static IPropertyMapper<Ad, AdHandler> PropertyMapper = new PropertyMapper<Ad, AdHandler>(ViewMapper)
    {

    };

    public static CommandMapper<Ad, AdHandler> CommandMapper = new(ViewCommandMapper)
    {

    };

    public AdHandler() : base(PropertyMapper, CommandMapper)
    {
    }
}
