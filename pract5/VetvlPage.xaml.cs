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
    /// Логика взаимодействия для VetvlPage.xaml
    /// </summary>
    public partial class VetvlPage : Page
    {
        public VetvlPage()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var x = Convert.ToDouble(tbx.Text);
                var y = Convert.ToDouble(tby.Text);
                var result = 0.0;
                var f = 0.0;

                if (rbCos.IsChecked == true)
                {
                    f = Math.Cos(x);
                }
                else if (rbExp.IsChecked == true)
                {
                    f = Math.Exp(x);
                }
                else if (rbSqr.IsChecked == true)
                {
                    f = Math.Sqrt(x);
                }
                else
                {
                    throw new Exception("Выберите функцию");
                }
                if(x * y > 0)
                {
                    result = (f + y) * (f + y);
                }
                else if (x * y < 0)
                {
                    result = f * Math.Cos(y);
                }
                else if (x * y == 0)
                {
                    result = f + y;
                }

                tbResult.Text = result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: "+ ex.Message);
            }
        }

        private void cbColor_Checked(object sender, RoutedEventArgs e)
        {
            if(cbColor.IsChecked == true)
            {
                tbResult.Foreground = Brushes.Red;
            }
            else
            {
                tbResult.Foreground = Brushes.Black;
            }
        }
    }
}
