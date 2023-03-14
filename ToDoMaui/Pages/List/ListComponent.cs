using CommunityToolkit.Mvvm.ComponentModel;
using MauiPlayground.Pages.List.Components;
using MauiPlayground.Viewmodels;
using System.ComponentModel;

namespace MauiPlayground.Pages.List;

public class ListComponent : ContentPage
{
    public ListComponent()
    {
        var vm = new ListVM();

        Entry entry = new Entry { Placeholder = "Enter text" };
        entry.Completed += (sender, args) =>
        {
            if(string.IsNullOrEmpty(entry.Text)){
                return;
            }

            vm.Add(entry.Text);
            entry.Text = null;
        };

        var statelessList = new StatelessList(vm);

        statelessList.DeletedRowId += (sender, args) =>
        {
            vm.delete(args);
        };

        Content = new VerticalStackLayout
        {
            Children = {

                entry,
                statelessList
            }
        };
    }
}
