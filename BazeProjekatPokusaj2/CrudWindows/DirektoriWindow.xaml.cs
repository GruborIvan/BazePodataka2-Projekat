using BazeProjekatPokusaj2.Repository;
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
    public partial class DirektoriWindow : Window
    {
        public BindingList<Osoba> Direktori { get; set; }

        public BindableCollection<Ugovor> Ugovori { get; set; }

        private IDirektorRepository _repository;

        private int editId = -1;

        public DirektoriWindow()
        {
            InitializeComponent();
            _repository = new DirektorRepository();
            Ugovori = new BindableCollection<Ugovor>(_repository.GetUgovori());
            LoadAllDirektors();
        }

        private void LoadAllDirektors()
        {
            Direktori = new BindingList<Osoba>(_repository.GetDirektori().ToList());
            DirektoriList.ItemsSource = Direktori;
            UgovorComboBox.ItemsSource = Ugovori;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            JMBGTextBox.Text = String.Empty;
            ImeTextBox.Text = String.Empty;
            PrezimeTextBox.Text = String.Empty;
            RadniStazTextBox.Text = String.Empty;
            UgovorComboBox.SelectedItem = null;
            this.editId = -1;
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to delete this direktor?", "Direktor", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var dir = ((FrameworkElement)sender).DataContext as Direktor;
                if (dir != null)
                {
                    _repository.DeleteDirektor(dir);
                    LoadAllDirektors();
                }
            }
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            var dir = ((FrameworkElement)sender).DataContext as Direktor;

            if (dir != null)
            {
                JMBGTextBox.Text = dir.JMBG.ToString();
                ImeTextBox.Text = dir.Ime;
                PrezimeTextBox.Text = dir.Prezime;
                RadniStazTextBox.Text = dir.RadniStaz;
                UgovorComboBox.SelectedItem = dir.Ugovor;
                this.editId = dir.OID;
            }
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateForm())
                return;
            Direktor dir;
            if (this.editId == -1)
            {
                dir = new Direktor();
                dir.JMBG = Convert.ToInt32(JMBGTextBox.Text);
                dir.Ime = ImeTextBox.Text;
                dir.Prezime = PrezimeTextBox.Text;
                dir.RadniStaz = RadniStazTextBox.Text;
                dir.UgovorUID = ((Ugovor)UgovorComboBox.SelectedItem).UID;
                _repository.AddDirektor(dir);
            }
            else
            {
                dir = _repository.GetDirektorById(this.editId);
                dir.JMBG = Convert.ToInt32(JMBGTextBox.Text);
                dir.Ime = ImeTextBox.Text;
                dir.Prezime = PrezimeTextBox.Text;
                dir.RadniStaz = RadniStazTextBox.Text;
                dir.UgovorUID = ((Ugovor)UgovorComboBox.SelectedItem).UID;
                _repository.UpdateDirektor(dir);
            }
            LoadAllDirektors();
            ClearForm();
        }

        private bool ValidateForm()
        {
            string alertText = String.Empty;

            Direktor dir = new Direktor();
            dir.Ime = ImeTextBox.Text;
            dir.Prezime = PrezimeTextBox.Text;
            dir.RadniStaz = RadniStazTextBox.Text;

            try
            {
                dir.JMBG = Convert.ToInt32(JMBGTextBox.Text);
            }
            catch (Exception e)
            {
                alertText += "JMBG mora biti u brojevnom formatu!";
            }


            if (dir.JMBG == 0)
                alertText += "Nije unet JMBG! \n";

            if (dir.JMBG < 5000)
                alertText += "JMBG mora biti veci od 5000! \n";

            if (dir.Ime == String.Empty)
                alertText += "Nije uneto ime Konsultanta! \n";

            if (dir.Prezime == String.Empty)
                alertText += "Nije uneto prezime Konsultanta! \n";

            if (dir.RadniStaz == String.Empty)
                alertText += "Nije unet radni staz konsultanta! \n";

            try
            {
                int rstz = Convert.ToInt32(dir.RadniStaz);
            }
            catch (Exception e)
            {
                alertText += "Radni staz mora biti broj (Godine) ! \n";
            }

            if (UgovorComboBox.SelectedItem == null)
                alertText += "Nije odabran nijedan ugovor za Konsultanta!";

            if (alertText != String.Empty)
            {
                System.Windows.MessageBox.Show(alertText, "ERROR", MessageBoxButton.OK);
                return false;
            }

            return true;
        }
    }
}
