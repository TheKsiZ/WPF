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

namespace day26
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
        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            if (Radio1.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R1TextA.Text);
                double f = Convert.ToDouble(R1ComboF.Text);
                this.Title = "Ответ: " + Math.Sin(f * a).ToString("F");
            }
            if (Radio2.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R2TextA.Text);
                double b = Convert.ToDouble(R2TextB.Text);
                double f = Convert.ToDouble(R2ComboF.Text);
                this.Title = "Ответ: " + (Math.Cos(f*a) + Math.Sin(f*b)).ToString("F");
            }
            if (Radio3.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R3TextA.Text);
                double b = Convert.ToDouble(R3TextB.Text);
                double c = Convert.ToDouble(R3ComboC.Text);
                double d = Convert.ToDouble(R3ComboD.Text);
                this.Title = "Ответ: " + (c * a * a + d * b * b).ToString("F");
            }
            if (Radio4.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R4TextA.Text);
                double d = Convert.ToDouble(R4TextD.Text);
                double c = Convert.ToDouble(R4ComboC.Text);
                double res = 1;
                for(int i = 0; i < d; i++)
                {
                    res = res * (c + a) + 1;
                }
                this.Title = "Ответ: " + res.ToString("F");
            }
            if (Radio5.IsChecked.GetValueOrDefault())
            {
                double x = Convert.ToDouble(R5TextX.Text);
                double y = Convert.ToDouble(R5TextY.Text);
                double n = Convert.ToDouble(R5ComboN.Text);
                double k = Convert.ToDouble(R5ComboK.Text);
                double res = 0;
                for(int i = 1; i <= n; i++)
                {
                    for(int j = 1; j <= k; j++)
                    {
                        res += (i * Math.Pow(x, 2 * i) + j * Math.Pow(y, 2 * j)) / (Math.Pow(i, 2) * Math.Pow(j, 2));
                    }
                }
                this.Title = "Ответ: " + res.ToString("F");
            }
        }
    }
}
