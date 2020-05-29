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

namespace GameOfLifeWithGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonStart(object sender, RoutedEventArgs e)
        {
            int antalCellerLangden = 30;
            int antalCellerHojden = 30;

            for (int i = 0; i < antalCellerHojden; i++)
            {
                for (int j = 0; j < antalCellerLangden; j++)
                {
                    Rectangle r = new Rectangle();
                    r.Width = Brade.ActualWidth / antalCellerLangden - 3.0;
                    r.Height = Brade.ActualHeight / antalCellerHojden -3.0;
                    r.Fill = Brushes.Red;
                    Brade.Children.Add(r);
                    Canvas.SetLeft(r, j * Brade.ActualWidth / antalCellerLangden);
                    Canvas.SetTop(r, i * Brade.ActualHeight / antalCellerHojden);
                }
            }
        }
    }
}
