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
    /// Логика взаимодействия для LineiPage.xaml
    /// </summary>
    public partial class LineiPage : Page
    {
        public LineiPage()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var x = Convert.ToDouble(tbx.Text);
                var y = Convert.ToDouble(tby.Text);
                var z = Convert.ToDouble(tbz.Text);
                double res = 0;

                if (Math.Pow(x, 2) + Math.Pow(y, 2) + 2 == 0)
                {
                    MessageBox.Show("Ошибка, знаменатель меньше нуля!");
                }
                else
                {
                    res = Math.Sqrt(Math.Pow(8 + Math.Pow(Math.Abs(x - y) + 1, 2), 1/3)) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 2) - Math.Pow(Math.E,Math.Abs(x-y)) * Math.Pow(Math.Pow(Math.Tan(z),2) + 1,x);
                    tbResult.Text = res.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
