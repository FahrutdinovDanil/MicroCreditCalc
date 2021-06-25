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

namespace MicroCreditCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int sum = Convert.ToInt32(DebtSum.Text);
            int time = Convert.ToInt32(DebtTime.Text);
            double sum_percent = 0;
            double timedouble = 0;
            for (int i = 0; i < time; i++)
            {
                if (i < 5)
                {
                    timedouble = sum * 0.009;
                    sum_percent = sum_percent + timedouble;
                }

                else if (i < 10)
                {
                    timedouble = sum * 0.007;
                    sum_percent = sum_percent + timedouble;
                }

                else if (i < time)
                {
                    timedouble = sum * 0.006;
                    sum_percent = sum_percent + timedouble;
                }
            }

            SumPay.Text = Convert.ToString(sum_percent + sum);
            SumPercent.Text = Convert.ToString(sum_percent);
        }
    }
}
