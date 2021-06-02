using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for FunkcijePrewiew.xaml
    /// </summary>
    public partial class FunkcijePrewiew : Window
    {
        public FunkcijePrewiew()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nazivKompanije = NazivKompanijeTextBox.Text;
            if (nazivKompanije.Equals(String.Empty))
            {
                MessageBox.Show("Niste uneli naziv kompanije!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            CompanyDbModelContainer db = new CompanyDbModelContainer();
            var ime = new SqlParameter("@ImeKompanije", NazivKompanijeTextBox.Text);
            var date = new SqlParameter() { ParameterName = "@return_value", DbType = System.Data.DbType.String, Size = 10, Direction = System.Data.ParameterDirection.Output };
            var t = db.Database.ExecuteSqlCommand("exec [dbo].[F_GET_KompanijaCount] @return_value OUTPUT, @ImeKompanije", date,ime);
        }
    }
}
