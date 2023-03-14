using MauiPlayground.Viewmodels;
using System;

namespace MauiPlayground.Pages.List.Components;

public partial class StatelessList : ContentView
{
    public event EventHandler<int> DeletedRowId;

    public StatelessList(ListVM vm)
	{
		InitializeComponent();

		listView.ItemsSource = vm.Rows;
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		//oof = sender.ToString();
		var btn = (Button)sender;
		var row = btn.BindingContext as ListRow;

        DeletedRowId.Invoke(this, row.Id);
    }
}