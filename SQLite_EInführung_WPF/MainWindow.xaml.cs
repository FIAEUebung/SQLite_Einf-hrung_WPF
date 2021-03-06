﻿using System;
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
            // TEST: Ausgabe_Vorname_TextBox.Text = Eingabe_Vorname_TextBox.Text;
            //TODO: Hier Datenbank Füllen

            /******* Erzeugt ein Objekt der Klasse SQLiteConnection Source ist die zuvor SQLiteEinführung.sqlite Datenbank dient als Schnittstelle ********/
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source = SQLiteEinführung.sqlite; Version = 3; Password = MyPass");
            ///****** Öffnet die Verbindung zur Datenbank *********/
            dbConnection.Open();
            //string vorname = Eingabe_Vorname_TextBox.Text;
            //string nachname = Eingabe_Nachname_TextBox.Text;

            string insertSql = "INSERT INTO personen(vorname, nachname, straße, hausnummer, plz, stadt, telefon, email) VALUES (@vorname, @nachname, @straße, @hausnummer, @plz, @stadt, @telefon, @email)";
            SQLiteCommand InsertCommand = new SQLiteCommand(insertSql, dbConnection);
            InsertCommand.Parameters.Add("@vorname", System.Data.DbType.String).Value = Eingabe_Vorname_TextBox.Text;
            InsertCommand.Parameters.Add("@nachname", System.Data.DbType.String).Value = Eingabe_Nachname_TextBox.Text;
            InsertCommand.Parameters.Add("@straße", System.Data.DbType.String).Value = Eingabe_Straße_TextBox.Text;
            InsertCommand.Parameters.Add("@hausnummer", System.Data.DbType.String).Value = Eingabe_Hausnummer_TextBox.Text;
            InsertCommand.Parameters.Add("@plz", System.Data.DbType.String).Value = Eingabe_PLZ_TextBox.Text;
            InsertCommand.Parameters.Add("@stadt", System.Data.DbType.String).Value = Eingabe_Stadt_TextBox.Text;
            InsertCommand.Parameters.Add("@telefon", System.Data.DbType.String ).Value = Eingabe_Telefonnummer_TextBox.Text;
            InsertCommand.Parameters.Add("@email", System.Data.DbType.String).Value = Eingabe_Email_TextBox.Text;



            InsertCommand.ExecuteNonQuery();
            InsertCommand.Parameters.Clear();
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

        private void Person_Hinzufügen_Button_Click(object sender, RoutedEventArgs e)
        {
            Eingabe_Vorname_TextBox.Clear();
            Eingabe_Nachname_TextBox.Clear();
            Eingabe_Straße_TextBox.Clear();
            Eingabe_Hausnummer_TextBox.Clear();
            Eingabe_PLZ_TextBox.Clear();
            Eingabe_Stadt_TextBox.Clear();
            Eingabe_Telefonnummer_TextBox.Clear();
            Eingabe_Email_TextBox.Clear();




        }

        private void Anzeigen_Button_Click(object sender, RoutedEventArgs e)
        {

            Page p = new Page();

          
            
        }
    }
}
