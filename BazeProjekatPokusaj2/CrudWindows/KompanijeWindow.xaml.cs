using BazeProjekatPokusaj2.Repository.Interfaces;
using BazeProjekatPokusaj2.Repository.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace BazeProjekatPokusaj2.CrudWindows
{
    /// <summary>
    /// Interaction logic for KompanijeWindow.xaml
    /// </summary>
    public partial class KompanijeWindow : Window
    {
        public static BindingList<Kompanija> Kompanije { get; set; }
        private int editId { get; set; }
        
        private IKompanijaRepository _repository;


        public KompanijeWindow()
        {
            InitializeComponent();
            _repository = new KompanijaRepository();
            this.editId = -1;
            LoadAllKompanije();
        }

        private void LoadAllKompanije()
        {
            Kompanije = new BindingList<Kompanija>(_repository.GetKompanije().ToList());
            KompanijeList.ItemsSource = Kompanije;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            string naziv = NazivTextBox.Text;
            string godOsnivanja = GodOsnivanjaTextBox.Text;
            string lokacija = LokacijaTextBox.Text;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.editId = -1;
            NazivTextBox.Text = String.Empty;
            GodOsnivanjaTextBox.Text = String.Empty;
            LokacijaTextBox.Text = String.Empty;
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            var kompanija = ((FrameworkElement)sender).DataContext as Kompanija;
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to delete this record?", "Kompanija", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var komp = ((FrameworkElement)sender).DataContext as Kompanija;
                if (komp != null)
                {
                    _repository.DeleteKompanija(komp);
                    LoadAllKompanije();
                }
            }
        }
    }
}
