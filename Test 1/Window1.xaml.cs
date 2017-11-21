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
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;



namespace Test_1
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        bool changingTitle = false;  // Prevent row changed events when changing title
        private void booksTitlesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            changingTitle = true;
            if (booksTitlesComboBox.SelectedValue != null)
            {
                //DataTable booksTable = (DataTable)((DataSourceProvider)FindResource("BooksTable")).Data;
                //int titleNumber = (int)booksTitlesComboBox.SelectedValue;
               // DatabaseTable.GetTable("SELECT * FROM issues WHERE Title=" + titleNumber, booksTable);
            }
            changingTitle = false;
        }
    }
    //

        

}
