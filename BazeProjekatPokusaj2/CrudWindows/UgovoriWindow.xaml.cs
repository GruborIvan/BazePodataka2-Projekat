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

namespace BazeProjekatPokusaj2
{
    /// <summary>
    /// Interaction logic for UgovoriWindow.xaml
    /// </summary>
    public partial class UgovoriWindow : Window
    {
        public static BindingList<Ugovor> Ugovori { get; set; }

        private IUgovorRepository _repository;
        private int editId { get; set; }

        public UgovoriWindow()
        {
            InitializeComponent();
            _repository = new UgovorRepository();
            this.editId = -1;
            LoadAllUgovori();
        }

        private void LoadAllUgovori()
        {
            Ugovori = new BindingList<Ugovor>(_repository.GetUgovori().ToList());
            UgovoriList.ItemsSource = Ugovori;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateForm())
                return;
            int TrajanjeUgovora = 0;

            try
            {
                // Validacija da li je unet broj!
                TrajanjeUgovora = Convert.ToInt32(TrajanjeUgovoraTextBox.Text);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Input error occured. Unable to parse Trajanje ugovora!", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                TrajanjeUgovoraTextBox.Text = String.Empty;
                return;
            }

            if (this.editId == -1)
            {
                Ugovor u = new Ugovor() {TrajanjeUgovora = TrajanjeUgovora.ToString()};
                _repository.AddUgovor(u);
            }
            else
            {
                Ugovor u = _repository.GetUgovorById(this.editId);
                u.TrajanjeUgovora = TrajanjeUgovora.ToString();
                _repository.UpdateUgovor(u);
            }

            this.editId = -1;
            TrajanjeUgovoraTextBox.Text = String.Empty;
            LoadAllUgovori();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.editId = -1;
            TrajanjeUgovoraTextBox.Text = String.Empty;
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            var ugovor = ((FrameworkElement)sender).DataContext as Ugovor;
            
            if (ugovor != null)
            {
                TrajanjeUgovoraTextBox.Text = ugovor.TrajanjeUgovora;
                this.editId = ugovor.UID;
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to delete this record?","Ugovor",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var ugovor = ((FrameworkElement)sender).DataContext as Ugovor;
                if (ugovor != null)
                {
                    _repository.DeleteUgovor(ugovor);
                    CompanyDbModelContainer db = new CompanyDbModelContainer();
                    Ugovor u = db.Ugovori.Find(ugovor.UID);
                    db.Ugovori.Remove(u);
                    db.SaveChanges();
                    LoadAllUgovori();
                }
            }
        }

        private bool ValidateForm()
        {
            string alertText = String.Empty;

            if (TrajanjeUgovoraTextBox.Text == String.Empty)
                alertText += "Unesite trajanje ugovora! \n";

            try
            {
                int trajanje = Convert.ToInt32(TrajanjeUgovoraTextBox.Text);
            }
            catch(Exception e)
            {
                alertText += "Trajanje ugovora mora biti broj (meseci).";
            }
            if (alertText != String.Empty)
            {
                System.Windows.MessageBox.Show(alertText, "ERROR", MessageBoxButton.OK);
                return false;
            }
            return true;
        }

    }
}
