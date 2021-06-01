using BazeProjekatPokusaj2.Repository.Interfaces;
using BazeProjekatPokusaj2.Repository.Repo;
using Caliburn.Micro;
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
    /// Interaction logic for UgovoreniProizvodi.xaml
    /// </summary>
    public partial class UgovoreniProizvodi : Window
    {
        IUgovoreniProizvodRepository _repository;

        public BindingList<UgovoreniProizvod> SviUgovoreniProizvodi { get; set; }
        public BindableCollection<Osoba> Klijenti { get; set; }
        public BindableCollection<Osoba> Konsultanti { get; set; }
        public BindableCollection<Osoba> Developeri { get; set; }

        private int editId = -1;

        public UgovoreniProizvodi()
        {
            InitializeComponent();
            _repository = new UgovoreniProizvodRepository();
            GetAllUgovoreniProizvodi();
        }

        private void GetAllUgovoreniProizvodi()
        {
            SviUgovoreniProizvodi = new BindingList<UgovoreniProizvod>(_repository.GetUgovoreniProizvodi().ToList());
            Klijenti = new BindableCollection<Osoba>(_repository.GetKlijenti().ToList());
            Konsultanti = new BindableCollection<Osoba>(_repository.GetKonsultanti().ToList());
            Developeri = new BindableCollection<Osoba>(_repository.GetDeveloperi().ToList());
            ProizvodiList.ItemsSource = SviUgovoreniProizvodi;
            KlijentComboBox.ItemsSource = Klijenti;
            DeveloperiComboBox.ItemsSource = Developeri;
            KonsultantComboBox.ItemsSource = Konsultanti;
        }

        private void ClearForm()
        {
            KlijentComboBox.SelectedItem = null;
            DeveloperiComboBox.SelectedItem = null;
            KonsultantComboBox.SelectedItem = null;
            OpisProizvodaTextBox.Text = String.Empty;
            VrednostProizvodaTextBox.Text = String.Empty;
            this.editId = -1;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            UgovoreniProizvod pro;
            if (this.editId == -1)
            {
                pro = new UgovoreniProizvod();
                pro.Klijent = (Klijent)KlijentComboBox.SelectedItem;
                pro.Konsultant = (Konsultant)KonsultantComboBox.SelectedItem;
                pro.Developer = (Developer)DeveloperiComboBox.SelectedItem;
                pro.OpisProizvoda = OpisProizvodaTextBox.Text;
                pro.VrednostProizvoda = VrednostProizvodaTextBox.Text;
                _repository.AddUgovoreniProizvod(pro);
            }
            else
            {
                pro = _repository.GetUgovoreniProizvodById(this.editId);
                pro.Klijent = (Klijent)KlijentComboBox.SelectedItem;
                pro.Konsultant = (Konsultant)KonsultantComboBox.SelectedItem;
                pro.Developer = (Developer)DeveloperiComboBox.SelectedItem;
                pro.OpisProizvoda = OpisProizvodaTextBox.Text;
                pro.VrednostProizvoda = VrednostProizvodaTextBox.Text;
                _repository.UpdateUgovoreniProizvod(pro);
            }
            GetAllUgovoreniProizvodi();
            ClearForm();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            var proizvod = ((FrameworkElement)sender).DataContext as UgovoreniProizvod;
            KlijentComboBox.SelectedItem = proizvod.Klijent;
            KonsultantComboBox.SelectedItem = proizvod.Konsultant;
            DeveloperiComboBox.SelectedItem = proizvod.Developer;
            OpisProizvodaTextBox.Text = proizvod.OpisProizvoda;
            VrednostProizvodaTextBox.Text = proizvod.VrednostProizvoda;
            this.editId = proizvod.PRID;
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to delete this record?", "Proizvod", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var proizvod = ((FrameworkElement)sender).DataContext as UgovoreniProizvod;
                if (proizvod != null)
                {
                    _repository.DeleteUgovoreniProizvod(proizvod);
                    GetAllUgovoreniProizvodi();
                }
            }
        }
    }
}
