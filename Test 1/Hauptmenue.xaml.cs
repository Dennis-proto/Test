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
    /// Interaktionslogik für Hauptmenue.xaml
    /// </summary>
    public partial class Hauptmenue : Window
    {
        public Hauptmenue()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // Auto vw;
            //vw = new Auto();
            Window Fenster;
            Fenster = new wAuftragsverwaltung();
            Fenster.Show();
            this.Close();
            //(MessageBox.Show(Convert.ToString(vw.Räder));
        }
        private void btnMitarbeiterAnlegen_Click(object sender, RoutedEventArgs e)
        {
            Window wmaanlegen = new wMitarbeiterAnlegen();
            wmaanlegen.Show();


        }
        private void btnCombobox_Click (object sender, RoutedEventArgs e)
            {
            Window ComboBoxer = new Window1();
            ComboBoxer.Show();




            }

    }
}
