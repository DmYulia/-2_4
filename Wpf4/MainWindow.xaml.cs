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

namespace Wpf4
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
            double rateCurrency = 0;
            double sumCurrency = 0;
            double resDouble;
            try
            {
                rateCurrency = Convert.ToDouble(rate.Text);
                if (rateCurrency < 0) throw new Exception("Ошибка ввода!");
            } catch { }
            try
            {
                sumCurrency = Convert.ToDouble(sum.Text);
                if (rateCurrency < 0) throw new Exception("Ошибка ввода!");
            } catch { }
            resDouble = rateCurrency * sumCurrency;
            resSun.Text = resDouble.ToString();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateCurrency = 0;
            double sumCurrency = 0;
            double resDouble;
            try
            {
                rateCurrency = Convert.ToDouble(rate1.Text);
                if (rateCurrency < 0) throw new Exception("Ошибка ввода!");
            }
            catch { }
            try
            {
                sumCurrency = Convert.ToDouble(sum1.Text);
                if (rateCurrency < 0) throw new Exception("Ошибка ввода!");
            }
            catch { }
            resDouble = rateCurrency * sumCurrency;
            resSun1.Text = resDouble.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateCurrency = 0;
            double sumCurrency = 0;
            double resDouble;
            try
            {
                rateCurrency = Convert.ToDouble(rate2.Text);
                if (rateCurrency < 0) throw new Exception("Ошибка ввода!");
            }
            catch { }
            try
            {
                sumCurrency = Convert.ToDouble(sum2.Text);
                if (rateCurrency < 0) throw new Exception("Ошибка ввода!");
            }
            catch { }
            resDouble = rateCurrency * sumCurrency;
            resSun2.Text = resDouble.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateCurrency = 0;
            double sumCurrency = 0;
            double resDouble;
            try
            {
                rateCurrency = Convert.ToDouble(rate3.Text);
                if (rateCurrency < 0) throw new Exception("Ошибка ввода!");
            }
            catch { }
            try
            {
                sumCurrency = Convert.ToDouble(sum3.Text);
                if (rateCurrency < 0) throw new Exception("Ошибка ввода!");
            }
            catch { }
            resDouble = rateCurrency * sumCurrency;
            resSun3.Text = resDouble.ToString();
        }

        private void Button_ClickDujm(object sender, RoutedEventArgs e)
        {
            double mrateDujm = 0;
            const double mdeltaDujm = 39.37;
            double mresDujm;
            try
            {
                mrateDujm = Convert.ToDouble(mrate.Text);
                if (mrateDujm < 0) throw new Exception("Ошибка ввода!");
            }
            catch { }
            mresDujm = mrateDujm / mdeltaDujm;
            mresSun.Text = mresDujm.ToString();
        }

        private void Button_ClickFut(object sender, RoutedEventArgs e)
        {
            double mrateF = 0;
            const double mdeltaF = 0.30479999767864;
            double mresF;
            try
            {
                mrateF = Convert.ToDouble(mrate1.Text);
                if (mrateF < 0) throw new Exception("Ошибка ввода!");
            }
            catch { }
            mresF = mrateF * mdeltaF;
            mresSun1.Text = mresF.ToString();
        }

        private void Button_ClickMiles(object sender, RoutedEventArgs e)
        {
            double mrateM = 0;
            const double mdeltaM = 1609.344;
            double mresM;
            try
            {
                mrateM = Convert.ToDouble(mrate2.Text);
                if (mrateM < 0) throw new Exception("Ошибка ввода!");
            }
            catch { }
            mresM = mrateM * mdeltaM;
            mresSun2.Text = mresM.ToString();
        }

        private void Button_ClickVerst(object sender, RoutedEventArgs e)
        {
            double mrateV = 0;
            const double mdeltaV = 1066.8;
            double mresV;
            try
            {
                mrateV = Convert.ToDouble(mrate3.Text);
                if (mrateV < 0) throw new Exception("Ошибка ввода!");
            }
            catch { }
            mresV = mrateV * mdeltaV;
            mresSun3.Text = mresV.ToString();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
