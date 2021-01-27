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

namespace B6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string buttonName;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            buttonName = "Binding data from code";
        }

        public string ButtonName { 
            get => buttonName;
            set { buttonName = value; OnPropertyChanged(ButtonName); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }    
        }        
        private void btnBinding_Click(object sender, RoutedEventArgs e)
        {
            txbBinding.Text = txbSource.Text;
        }
    }
}
