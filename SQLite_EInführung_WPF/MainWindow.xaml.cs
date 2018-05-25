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
using System.Xaml;


namespace SQLite_EInführung_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /* ERZEUGUNG EINER SQL DATENBANK */

            /*********** Erzeugt die SQLite Datenbank ***********/
            SQLiteConnection.CreateFile("SQLiteEinführung.sqlite");
            /* VERBINDUNG ZUR DATENBANK */
            /******* Erzeugt ein Objekt der Klasse SQLiteConnection Source ist die zuvor SQLiteEinführung.sqlite Datenbank dient als Schnittstelle ********/
             SQLiteConnection dbConnection = new SQLiteConnection("Data Source = SQLiteEinführung.sqlite; Version = 3; Password = MyPass");
            /****** Öffnet die Verbindung zur Datenbank *********/
            dbConnection.Open();

            /*Erzeugt eine Tabelle mit den spalten id, vorname und nachname*/
            string createSql = "CREATE TABLE personen(personen_id INTEGER NOT NULL PRIMARY KEY, vorname TEXT, nachname TEXT, straße TEXT, hausnummer TEXT, plz TEXT, stadt TEXT, telefon TEXT, email TEXT)";
            SQLiteCommand CreateTableCommand = new SQLiteCommand(createSql, dbConnection);
            CreateTableCommand.ExecuteNonQuery();

        

        }

        private void Abschicken_Button_Click(object sender, RoutedEventArgs e)
        {

            ////TODO: FIX IT
            ///* AUSWÄHLEN VON DATENSÄTZEN */




            //StringBuilder dbString = new StringBuilder();
            //while (reader.Read())
            //{

            //    Ausgabe_Vorname_TextBox.Text = reader.GetValue(1).ToString();
            //    Ausgabe_Nachname_TextBox.Text = reader.GetValue(2).ToString();
            //    Ausgabe_Straße_TextBox.Text = reader.GetValue(3).ToString();
            //    Ausgabe_Hausnummer_TextBox.Text = reader.GetValue(4).ToString();
            //    Ausgabe_PLZ_TextBox.Text = reader.GetValue(5).ToString();
            //    Ausgabe_Stadt_TextBox.Text = reader.GetValue(6).ToString();
            //    Ausgabe_Telefonnummer_TextBox.Text = reader.GetValue(7).ToString();
            //    Ausgabe_Email_TextBox.Text = reader.GetValue(8).ToString();
            //}

        }

        private void Neue_Person_Anlegen_Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Visibility = Visibility.Hidden;
            Main.Content = new Page2();



        }

        private void Anzeigen_Button_Click(object sender, RoutedEventArgs e)
        {
            
            Main.Content = new Page1();
            


        }
    }
}
