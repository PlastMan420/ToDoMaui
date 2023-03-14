namespace MauiPlayground.Pages.List.Components;

public class StatelessListMVU : ContentView
{
	public StatelessListMVU()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}