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
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;



namespace Test_1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                string strbenutzername;
                string strpasswort;
                strbenutzername = tbBenutzername.Text;
                strpasswort = tbPasswort.Password;
                //This is my connection string i have assigned the database file address path  
                //string MyConnection2 = "server=localhost;port=3307;uid=root;pwd=test";
                string MyConnection2 = "server=localhost;uid=" + strbenutzername + ";pwd=" + strpasswort + ";database=protoform;";
                //This is my insert query in which i am taking input from the user through windows forms  
                //string Query = "insert into protoform.Abteilung(Abteilung,Kostenstelle) values('" + strAbteilung + "','" + iKostenstelle + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                //MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                //MessageBox.Show("Save Data");
                //while (MyReader2.Read())
                //{
                //}
                //MyConn2.Close();
                Window wHauptmenue;
                wHauptmenue = new Hauptmenue();
                wHauptmenue.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Benutzername oder Passwort falsch");
          

            }
        }

    }
    class DatabaseTable
    {

        MySqlConnection connection;
        MySqlDataAdapter adapter;
        public DataTable GetTable(string query, string SortyBy)
        {
            String connString = "server=localhost;uid=root;pwd=test;database=protoform;";
            connection = new MySqlConnection(connString);
            adapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataTable.DefaultView.Sort = SortyBy;
            return dataTable;


        }

    }
}
