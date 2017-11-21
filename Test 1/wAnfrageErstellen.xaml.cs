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
using MySql.Data.MySqlClient;


namespace Test_1
{
    /// <summary>
    /// Interaktionslogik für wAnfrageErstellen.xaml
    /// </summary>
    public partial class wAnfrageErstellen : Window
    {
        public wAnfrageErstellen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*string strAbteilung;
            int iKostenstelle;
            strAbteilung = tbAbteilung.Text;
            iKostenstelle = Convert.ToInt32(tbKostenstelle.Text);
            //This is my connection string i have assigned the database file address path  
            //string MyConnection2 = "server=localhost;port=3307;uid=root;pwd=test";
            string MyConnection2 = "server=localhost;uid=root;pwd=test;";
            //This is my insert query in which i am taking input from the user through windows forms  
            string Query = "insert into protoform.Abteilung(Abteilung,Kostenstelle) values('" + strAbteilung + "','" + iKostenstelle + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            MessageBox.Show("Save Data");
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();*/
        }
    }
}
