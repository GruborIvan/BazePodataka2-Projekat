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
    /// Interaction logic for DeveloperiWindow.xaml
    /// </summary>
    public partial class DeveloperiWindow : Window
    {
        public BindingList<Osoba> Developeri { get; set; }
        private int editId = -1;
        private IDeveloperRepository _repository;

        public BindableCollection<Ugovor> Ugovori { get; set; }

        public DeveloperiWindow()
        {
            InitializeComponent();
            _repository = new DeveloperRepository();
            Ugovori = new BindableCollection<Ugovor>(_repository.GetUgovori());
            LoadAllDevelopers();
        }

        private void LoadAllDevelopers()
        {
            Developeri = new BindingList<Osoba>(_repository.GetDeveloperi().ToList());
            DeveloperiList.ItemsSource = Developeri;
            UgovorComboBox.ItemsSource = Ugovori;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Developer developer;
            if (this.editId == -1)
            {
                developer = new Developer();
                developer.JMBG = Convert.ToInt32(JmbgTextBox.Text);
                developer.Ime = ImeTextBox.Text;
                developer.Prezime = PrezimeTextBox.Text;
                developer.RadniStaz = RadniStazTextBox.Text;
                developer.UgovorUID = 3;
                developer.PreferiranaTehnologija = TehnologijeTextBox.Text;
                developer.UgovorUID = ((Ugovor)UgovorComboBox.SelectedItem).UID;
                _repository.AddDeveloper(developer);
            }
            else
            {
                developer = _repository.GetDeveloperById(this.editId);
                developer.JMBG = Convert.ToInt32(JmbgTextBox.Text);
                developer.Ime = ImeTextBox.Text;
                developer.Prezime = PrezimeTextBox.Text;
                developer.RadniStaz = RadniStazTextBox.Text;
                developer.PreferiranaTehnologija = TehnologijeTextBox.Text;
                developer.UgovorUID = ((Ugovor)UgovorComboBox.SelectedItem).UID;
                _repository.UpdateDeveloper(developer);
            }
            LoadAllDevelopers();
            ClearForm();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            JmbgTextBox.Text = String.Empty;
            ImeTextBox.Text = String.Empty;
            PrezimeTextBox.Text = String.Empty;
            RadniStazTextBox.Text = String.Empty;
            TehnologijeTextBox.Text = String.Empty;
            UgovorComboBox.SelectedItem = null;
            this.editId = -1;
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            var dev = ((FrameworkElement)sender).DataContext as Developer;

            if (dev != null)
            {
                JmbgTextBox.Text = dev.JMBG.ToString();
                ImeTextBox.Text = dev.Ime;
                PrezimeTextBox.Text = dev.Prezime;
                RadniStazTextBox.Text = dev.RadniStaz;
                TehnologijeTextBox.Text = dev.PreferiranaTehnologija;
                UgovorComboBox.SelectedItem = dev.Ugovor;
                this.editId = dev.OID;
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to delete this developer?", "Developer", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var dev = ((FrameworkElement)sender).DataContext as Developer;
                if (dev != null)
                {
                    _repository.DeleteDeveloper(dev);
                    LoadAllDevelopers();
                }
            }
        }
    }
}
