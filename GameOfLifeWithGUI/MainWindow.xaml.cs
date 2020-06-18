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

        const int antalCellerLangden = 30;
        const int antalCellerHojden = 30;
        Rectangle[,] falt = new Rectangle[antalCellerLangden , antalCellerHojden];

        private void ButtonStart(object sender, RoutedEventArgs e)
        {
            

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
                    r.MouseDown += R_MouseDown;

                    falt[i, j] = r;
                }
            }
        }

        private void R_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(((Rectangle)sender).Fill == Brushes.Red)
                {
                ((Rectangle)sender).Fill = Brushes.Black;
                    
                }

           else { ((Rectangle)sender).Fill = Brushes.Red; }
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            int[,] numberOfNeighbours = new int[antalCellerHojden, antalCellerLangden];
            for (int i = 0; i < antalCellerHojden; i++)
            {
                for (int j = 0; j < antalCellerLangden; j++)
                {
                    int neighbours = 0;
                    numberOfNeighbours[i, j] = neighbours;
                }
            }
        }

        
    }
}
