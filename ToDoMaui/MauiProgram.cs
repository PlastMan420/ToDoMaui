using MauiPlayground.Pages.List;
using MauiPlayground.Viewmodels;
using Microsoft.Extensions.Logging;

namespace MauiPlayground;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<ListVM>();
		builder.Services.AddTransient<ListComponent>(x => new ListComponent() {
			BindingContext = x.GetService<ListVM>()
		});

		return builder.Build();
	}
}
