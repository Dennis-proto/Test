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

namespace Test_1
{
    /// <summary>
    /// Interaktionslogik für wAuftragsverwaltung.xaml
    /// </summary>
    public partial class wAuftragsverwaltung : Window
    {
        public wAuftragsverwaltung()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window Fenster;
            Fenster = new wAnfragenverwaltung();
            Fenster.Show();
            this.Close();
        }
    }
}
