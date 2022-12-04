using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using milkdrunk.Controls;
using milkdrunk.Handlers;

namespace milkdrunk;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkitMarkup()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureMauiHandlers(handlers =>
			{
				handlers.AddHandler(typeof(Ad), typeof(AdHandler));
            });

		return builder.Build();
	}
}
