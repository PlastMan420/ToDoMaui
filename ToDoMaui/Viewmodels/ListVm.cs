using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiPlayground.Viewmodels
{
    public class ListVM : ObservableObject
    {
        int counter = 1;

        public ListVM()
        {
            Rows = new ObservableCollection<ListRow>();
        }

        public ListVM(List<ListRow> rows)
        {
            Rows = new ObservableCollection<ListRow>(rows);
        }

        public ObservableCollection<ListRow> Rows { get; set; }

        public void Add(string text)
        {
            var row = new ListRow()
            {
                Id = counter,
                Name = text
            };

            this.Rows.Add(row);

            counter += 1;
        }

        public void delete(int id)
        {
            var row = this.Rows.Single(x => x.Id == id);
            this.Rows.Remove(row);
        }
    }

    public class ListRow : ObservableObject
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
