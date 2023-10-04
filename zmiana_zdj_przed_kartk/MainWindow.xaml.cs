using System;
using System.Collections;
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

namespace zmiana_zdj_przed_kartk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int id_Zdj = 0;

        List<string> zdj = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            zdj.Add("images/zdj1.png");
            zdj.Add("images/zdj12.png");
            zdj.Add("images/zdj3.png");
            zdj.Add("images/zdj4.png");
        }
        private void Pokaz_Zdj_Radio(object sender, RoutedEventArgs e)
        {
            if(pierw.IsChecked == true)
            {
                id_Zdj = 0;
                Zdj.Source = new BitmapImage(new Uri(zdj[id_Zdj], UriKind.Relative));
            }
            else
            {
                if(drugie.IsChecked == true)
                {
                    id_Zdj = 1;
                    Zdj.Source = new BitmapImage(new Uri(zdj[id_Zdj], UriKind.Relative));
                }
                else
                {
                    if(trzecie.IsChecked == true)
                    {
                        id_Zdj = 2;
                        Zdj.Source = new BitmapImage(new Uri(zdj[id_Zdj], UriKind.Relative));
                    }
                    else
                    {
                        id_Zdj = 3;
                        Zdj.Source = new BitmapImage(new Uri(zdj[id_Zdj], UriKind.Relative));
                    }
                }
            }
        }

        private void Pokaz_Zdj_Label(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(id_zdj_label.Text ,out int a))
            {
                if( (a > 0) && ( a < 5))
                {
                    id_Zdj = a-1;
                    Zdj.Source = new BitmapImage(new Uri(zdj[id_Zdj], UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("podaj liczbe z zakresu 1 - 4", "cos");
                }

            }
        }

        private void Button_Wstecz(object sender, RoutedEventArgs e)
        {
            if (id_Zdj > 0)
            {
                id_Zdj--;
                Zdj.Source = new BitmapImage(new Uri(zdj[id_Zdj], UriKind.Relative));
            }
            else
            {
                id_Zdj = 3;
                Zdj.Source = new BitmapImage(new Uri(zdj[id_Zdj], UriKind.Relative));
            }
        }

        private void Button_Dalej(object sender, RoutedEventArgs e)
        {
            if (id_Zdj < 3)
            {
                id_Zdj++;
                Zdj.Source = new BitmapImage(new Uri(zdj[id_Zdj], UriKind.Relative));
            }
            else
            {
                id_Zdj = 0;
                Zdj.Source = new BitmapImage(new Uri(zdj[id_Zdj], UriKind.Relative));
            }
        }
    }
}
