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
    /// Interaction logic for KlijentiWindow.xaml
    /// </summary>
    public partial class KlijentiWindow : Window
    {
        public BindingList<Osoba> Klijenti { get; set; }

        private IKlijentRepository _repository;

        private int editId = -1;

        public KlijentiWindow()
        {
            InitializeComponent();
            _repository = new KlijentRepository();
            LoadAllKlijents();
        }

        private void LoadAllKlijents()
        {
            Klijenti = new BindingList<Osoba>(_repository.GetKlijenti().ToList());
            KlijentiList.ItemsSource = Klijenti;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.editId = -1;
            ClearForm();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Klijent client;
            if (this.editId == -1)
            {
                client = new Klijent();
                client.JMBG = Convert.ToInt32(JmbgTextBox.Text);
                client.Ime = ImeTextBox.Text;
                client.Prezime = PrezimeTextBox.Text;
                client.NazivKlijenta = NazivKlijentaTextBox.Text;
                _repository.AddKlijent(client);
            }
            else
            {
                client = _repository.GetKlijentById(this.editId);
                client.JMBG = Convert.ToInt32(JmbgTextBox.Text);
                client.Ime = ImeTextBox.Text;
                client.Prezime = PrezimeTextBox.Text;
                client.NazivKlijenta = NazivKlijentaTextBox.Text;
                _repository.UpdateKlijent(client);
            }
            
            LoadAllKlijents();
            ClearForm();
        }

        private void ClearForm()
        {
            JmbgTextBox.Text = String.Empty;
            ImeTextBox.Text = String.Empty;
            PrezimeTextBox.Text = String.Empty;
            NazivKlijentaTextBox.Text = String.Empty;
            this.editId = -1;
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            var kli = ((FrameworkElement)sender).DataContext as Klijent;

            if (kli != null)
            {
                JmbgTextBox.Text = kli.JMBG.ToString();
                ImeTextBox.Text = kli.Ime;
                PrezimeTextBox.Text = kli.Prezime;
                NazivKlijentaTextBox.Text = kli.NazivKlijenta;
                this.editId = kli.OID;
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to delete this klijent?", "Klijent", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var klient = ((FrameworkElement)sender).DataContext as Klijent;
                if (klient != null)
                {
                    _repository.DeleteKlijent(klient);
                    LoadAllKlijents();
                }
            }
        }
    }
}
