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

namespace pract5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbTime.Text = DateTime.Now.ToString();
        }

        private void btnLinein_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Source = new Uri("pack://application:,,,/LineiPage.xaml");
        }

        private void btnVtvl_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Source = new Uri("pack://application:,,,/VetvlPage.xaml");
        }
    }
}
