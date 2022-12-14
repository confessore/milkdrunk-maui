using Microsoft.Maui.Handlers;
using milkdrunk.Controls;
using milkdrunk.Platforms.MacCatalyst.Controls;

namespace milkdrunk.Handlers
{
    public partial class AdHandler : ViewHandler<Ad, MauiAd>
    {
        protected override MauiAd CreatePlatformView() =>
            new(VirtualView);

        protected override void ConnectHandler(MauiAd platformView)
        {
            base.ConnectHandler(platformView);

            // Perform any control setup here
        }

        protected override void DisconnectHandler(MauiAd platformView)
        {
            platformView.Dispose();
            base.DisconnectHandler(platformView);
        }
    }
}
