using BazeProjekatPokusaj2.CrudWindows;
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

namespace BazeProjekatPokusaj2
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

        private void Ugovori_Click(object sender, RoutedEventArgs e)
        {
            UgovoriWindow ugovoriWindow = new UgovoriWindow();
            ugovoriWindow.Show();
        }

        private void Kompanije_Click(object sender, RoutedEventArgs e)
        {
            KompanijeWindow kompanijeWindow = new KompanijeWindow();
            kompanijeWindow.Show();
        }

        private void Lokacije_Click(object sender, RoutedEventArgs e)
        {
            LokacijeWindow lokacijeWindow = new LokacijeWindow();
            lokacijeWindow.Show();
        }

        private void Konsultanti_Click(object sender, RoutedEventArgs e)
        {
            KonsultantiWindow konsultantiWindow = new KonsultantiWindow();
            konsultantiWindow.Show();
        }

        private void Developeri_Click(object sender, RoutedEventArgs e)
        {
            DeveloperiWindow developeriWindow = new DeveloperiWindow();
            developeriWindow.Show();
        }

        private void Direktori_Click(object sender, RoutedEventArgs e)
        {
            DirektoriWindow direktoriWindow = new DirektoriWindow();
            direktoriWindow.Show();
        }

        private void Klijenti_Click(object sender, RoutedEventArgs e)
        {
            KlijentiWindow klijentiWindow = new KlijentiWindow();
            klijentiWindow.Show();
        }

        private void Proizvodi_Click(object sender, RoutedEventArgs e)
        {
            UgovoreniProizvodi ugovoreniProizvodi = new UgovoreniProizvodi();
            ugovoreniProizvodi.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FunkcijePrewiew fpw = new FunkcijePrewiew();
            fpw.Show();
        }
    }
   
}
