using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace milkdrunk;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
