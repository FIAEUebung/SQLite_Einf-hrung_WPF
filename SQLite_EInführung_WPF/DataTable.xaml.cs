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
using System.Windows.Shapes;
using System.Data.SQLite;

namespace SQLite_EInführung_WPF
{
    /// <summary>
    /// Interaktionslogik für DataTable.xaml
    /// </summary>
    public partial class DataTable : Window
    {
        public DataTable()
        {
            InitializeComponent();

            SQLiteConnection dbConnection = new SQLiteConnection("Data Source = SQLiteEinführung.sqlite; Version = 3; Password = MyPass");
            dbConnection.Open();

            string chooseSql = "SELECT * FROM personen";
            SQLiteCommand ChooseCommand = new SQLiteCommand(chooseSql, dbConnection);
            Data_Table_DataGrid.DataContext = ChooseCommand;

            SQLiteDataReader reader = ChooseCommand.ExecuteReader();
        }

    }
}
