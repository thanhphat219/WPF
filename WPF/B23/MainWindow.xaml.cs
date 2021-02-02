using System;
using System.Collections.Generic;
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

namespace B23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Food> listName;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listName = new List<Food> {
            new Food() {Name = "Tôm", Price = "20.000"},
            new Food() {Name = "Cua", Price = "50.000"},
            new Food() {Name = "Cá", Price = "100.000"},
            };
            cbItemSource.ItemsSource = listName;
            //cbItemSource.DisplayMemberPath = "Name";
            cbItemSource.SelectionChanged += CbItemSource_SelectionChanged;
            //cbItemSource.SelectedValuePath = "Price";

            cbColor.ItemsSource = typeof(Colors).GetProperties();
        }

        private void CbItemSource_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(cbItemSource.SelectedValue.ToString());
        }
    }
    public class Food
    {
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
