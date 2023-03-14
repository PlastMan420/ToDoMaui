using MauiPlayground.Pages.List;

namespace MauiPlayground;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ListComponent), typeof(ListComponent));
	}
}
