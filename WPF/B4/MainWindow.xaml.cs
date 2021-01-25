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

namespace B4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button button = new Button();
            button.Click += Button_Click;
            //button.Content = "Free Education";
            gird.Children.Add(button);

            //TextBlock textBlock = new TextBlock();
            //textBlock.Text = "Share to be better";
            //button.Content = textBlock;

            TextBox textBox = new TextBox();
            textBox.Height = 50;
            textBox.Width = 100;
            button.Content = textBox;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click");
        }
    }
}
