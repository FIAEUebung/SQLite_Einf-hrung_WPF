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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;

namespace SQLite_EInführung_WPF
{
    /// <summary>
    /// Interaktionslogik für Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        //private void Abschicken_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // TEST: Ausgabe_Vorname_TextBox.Text = Eingabe_Vorname_TextBox.Text;
        //    //TODO: Hier Datenbank Füllen

        //    /******* Erzeugt ein Objekt der Klasse SQLiteConnection Source ist die zuvor SQLiteEinführung.sqlite Datenbank dient als Schnittstelle ********/
        //    SQLiteConnection dbConnection = new SQLiteConnection("Data Source = SQLiteEinführung.sqlite; Version = 3; Password = MyPass");
        //    ///****** Öffnet die Verbindung zur Datenbank *********/
        //    dbConnection.Open();
        //    //string vorname = Eingabe_Vorname_TextBox.Text;
        //    //string nachname = Eingabe_Nachname_TextBox.Text;

        //   string insertSql = "INSERT INTO personen(vorname, nachname, straße, hausnummer, plz, stadt, telefon, email) VALUES (@vorname, @nachname, @straße, @hausnummer, @plz, @stadt, @telefon, @email)";
        //    SQLiteCommand InsertCommand = new SQLiteCommand(insertSql, dbConnection);
        //    InsertCommand.Parameters.Add("@vorname", System.Data.DbType.String).Value = Eingabe_Vorname_TextBox.Text;
        //    InsertCommand.Parameters.Add("@nachname", System.Data.DbType.String).Value = Eingabe_Nachname_TextBox.Text;
        //    InsertCommand.Parameters.Add("@straße", System.Data.DbType.String).Value = Eingabe_Straße_TextBox.Text;
        //    InsertCommand.Parameters.Add("@hausnummer", System.Data.DbType.String).Value = Eingabe_Hausnummer_TextBox.Text;
        //    InsertCommand.Parameters.Add("@plz", System.Data.DbType.String).Value = Eingabe_PLZ_TextBox.Text;
        //    InsertCommand.Parameters.Add("@stadt", System.Data.DbType.String).Value = Eingabe_Stadt_TextBox.Text;
        //    InsertCommand.Parameters.Add("@telefon", System.Data.DbType.String).Value = Eingabe_Telefonnummer_TextBox.Text;
        //    InsertCommand.Parameters.Add("@email", System.Data.DbType.String).Value = Eingabe_Email_TextBox.Text;



        //    InsertCommand.ExecuteNonQuery();
        //    InsertCommand.Parameters.Clear();
        //}

        private void Person_Hinzufügen_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Anzeigen_Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
