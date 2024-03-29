﻿using BazeProjekatPokusaj2.Repository.Interfaces;
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
    /// Interaction logic for KonsultantiWindow.xaml
    /// </summary>
    public partial class KonsultantiWindow : Window
    {
        public BindingList<Osoba> Konsultanti { get; set; }
        private int editId = -1;
        private IKonsultantRepository _repository;
        public BindableCollection<Ugovor> Ugovori { get; set; }

        public KonsultantiWindow()
        {
            InitializeComponent();
            _repository = new KonsultantRepository();
            Ugovori = new BindableCollection<Ugovor>(_repository.GetUgovori());
            LoadAllKonsultanti();
        }

        private void LoadAllKonsultanti()
        {
            Konsultanti = new BindingList<Osoba>(_repository.GetKonsultanti().ToList());
            KonsultantiList.ItemsSource = Konsultanti;
            UgovorComboBox.ItemsSource = Ugovori;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (!Validate())
                return;
            Konsultant konsultant;
            if (this.editId == -1)
            {
                konsultant = new Konsultant();
                konsultant.JMBG = Convert.ToInt32(JmbgTextBox.Text);
                konsultant.Ime = ImeTextBox.Text;
                konsultant.Prezime = PrezimeTextBox.Text;
                konsultant.RadniStaz = RadniStazTextBox.Text;
                konsultant.UgovorUID = ((Ugovor)UgovorComboBox.SelectedItem).UID;
                _repository.AddKonsultant(konsultant);
            }
            else
            {
                konsultant = _repository.GetKonsultantById(this.editId);
                konsultant.JMBG = Convert.ToInt32(JmbgTextBox.Text);
                konsultant.Ime = ImeTextBox.Text;
                konsultant.Prezime = PrezimeTextBox.Text;
                konsultant.RadniStaz = RadniStazTextBox.Text;
                konsultant.UgovorUID = ((Ugovor)UgovorComboBox.SelectedItem).UID;
                _repository.UpdateKonsultant(konsultant);
            }
            LoadAllKonsultanti();
            ClearForm();
        }

        private void ClearForm()
        {
            JmbgTextBox.Text = String.Empty;
            ImeTextBox.Text = String.Empty;
            PrezimeTextBox.Text = String.Empty;
            RadniStazTextBox.Text = String.Empty;
            UgovorComboBox.SelectedItem = null;
            this.editId = -1;
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            var kons = ((FrameworkElement)sender).DataContext as Konsultant;

            if (kons != null)
            {
                JmbgTextBox.Text = kons.JMBG.ToString();
                ImeTextBox.Text = kons.Ime;
                PrezimeTextBox.Text = kons.Prezime;
                RadniStazTextBox.Text = kons.RadniStaz;
                UgovorComboBox.SelectedItem = kons.Ugovor;
                this.editId = kons.OID;
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to delete this developer?", "Developer", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var kons = ((FrameworkElement)sender).DataContext as Konsultant;
                if (kons != null)
                {
                    _repository.DeleteKonsultant(kons);
                    LoadAllKonsultanti();
                }
            }
        }
    
        private bool Validate()
        {
            string alertText = String.Empty;
            Konsultant konsultant = new Konsultant();
            try
            {
                konsultant.JMBG = Convert.ToInt32(JmbgTextBox.Text);
            }
            catch(Exception e)
            {
                alertText += "JMBG mora biti u brojevnom formatu!";
            }
            
            konsultant.Ime = ImeTextBox.Text;
            konsultant.Prezime = PrezimeTextBox.Text;
            konsultant.RadniStaz = RadniStazTextBox.Text;

            if (konsultant.JMBG == 0)
                alertText += "Nije unet JMBG! \n";

            if (konsultant.JMBG < 5000)
                alertText += "JMBG mora biti veci od 5000! \n";

            if (konsultant.Ime == String.Empty)
                alertText += "Nije uneto ime Konsultanta! \n";

            if (konsultant.Prezime == String.Empty)
                alertText += "Nije uneto prezime Konsultanta! \n";

            if (konsultant.RadniStaz == String.Empty)
                alertText += "Nije unet radni staz konsultanta! \n";

            try
            {
                int rstz = Convert.ToInt32(konsultant.RadniStaz);
            }
            catch(Exception e)
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
