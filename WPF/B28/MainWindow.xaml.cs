using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace B28
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsSort = false;
        public MainWindow()
        {
            InitializeComponent();
			List<User> items = new List<User>();
			items.Add(new User() { Name = "John Doe", Age = 42 });
			items.Add(new User() { Name = "Jane Doe", Age = 39 });
			items.Add(new User() { Name = "Sammy Doe", Age = 13 });
			items.Add(new User() { Name = "Donna Doe", Age = 13 });
			lvUsers.ItemsSource = items;

			//CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
			//view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
		}

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader header = sender as GridViewColumnHeader;   
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            if (IsSort)
            {
                view.SortDescriptions.Remove(new SortDescription(header.Content.ToString(), ListSortDirection.Descending));
                view.SortDescriptions.Add(new SortDescription(header.Content.ToString(), ListSortDirection.Ascending));
            }    
            else
            {
                view.SortDescriptions.Remove(new SortDescription(header.Content.ToString(), ListSortDirection.Ascending));
                view.SortDescriptions.Add(new SortDescription(header.Content.ToString(), ListSortDirection.Descending));
            }    
            IsSort = !IsSort;
        }
    }

    public class User
	{
		public string Name { get; set; }

		public int Age { get; set; }
	}
}

