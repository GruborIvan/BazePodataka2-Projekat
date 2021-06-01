using BazeProjekatPokusaj2.Repository;
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
    /// Interaction logic for LokacijeWindow.xaml
    /// </summary>
    public partial class LokacijeWindow : Window
    {
        public BindingList<Lokacija> Lokacije { get; set; }

        private ILokacijaRepository _repository;

        private int editId { get; set; }

        public LokacijeWindow()
        {
            InitializeComponent();
            _repository = new LokacijaRepository();
            this.editId = -1;
            LoadAllLocations();
        }

        private void LoadAllLocations()
        {
            Lokacije = new BindingList<Lokacija>(_repository.GetLokacije().ToList());
            LokacijeList.ItemsSource = Lokacije;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateForm())
                return;
            string nazivGrada = GradTextBox.Text;
            string nazivUlice = UlicaTextBox.Text;
            string postanskiBroj = PostanskiBrojTextBox.Text;

            if (this.editId == -1)
            {
                Lokacija lok = new Lokacija() { Grad = nazivGrada, Ulica = nazivUlice, PostanskiBroj = postanskiBroj };
                _repository.AddLokacija(lok);
            }
            else
            {
                Lokacija lok = _repository.GetLokacijaById(editId);
                lok.Grad = nazivGrada;
                lok.Ulica = nazivUlice;
                lok.PostanskiBroj = postanskiBroj;
                _repository.UpdateLokacija(lok);
            }
            LoadAllLocations();
            ClearForm();
        }
       
        private void ClearForm()
        {
            GradTextBox.Text = String.Empty;
            UlicaTextBox.Text = String.Empty;
            PostanskiBrojTextBox.Text = String.Empty;
            this.editId = -1;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            var lokacija = ((FrameworkElement)sender).DataContext as Lokacija;
            if (lokacija != null)
            {
                GradTextBox.Text = lokacija.Grad;
                UlicaTextBox.Text = lokacija.Ulica;
                PostanskiBrojTextBox.Text = lokacija.PostanskiBroj;
                this.editId = lokacija.LokID;
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            var lokacija = ((FrameworkElement)sender).DataContext as Lokacija;
            if (lokacija != null)
            {
                _repository.DeleteLokacija(lokacija);
                LoadAllLocations();
            }
        }

        private bool ValidateForm()
        {
            string alertText = String.Empty;

            string nazivGrada = GradTextBox.Text;
            string nazivUlice = UlicaTextBox.Text;
            string postanskiBroj = PostanskiBrojTextBox.Text;

            if (nazivGrada == String.Empty)
            {
                alertText += "Naziv Grada field is empty! \n";
            }
            if (nazivUlice == String.Empty)
            {
                alertText += "Naziv Ulice field is empty! \n";
            }
            if (postanskiBroj == String.Empty)
            {
                alertText += "Postanski broj is empty! \n";
            }
            
            try
            {
                Int64 br = Convert.ToInt64(postanskiBroj);
            }
            catch(Exception e)
            {
                alertText += "Postanski broj mora biti broj! \n";
            }

            if (alertText != String.Empty)
            {
                MessageBox.Show(alertText, "ERROR", MessageBoxButton.OK);
                return false;
            }
            return true;
        }

    }
}
