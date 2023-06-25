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

namespace NET_ININ3_PR2_Z4
{
    /// <summary>
    /// Logika interakcji dla klasy Marka.xaml
    /// </summary>
    public partial class Marka : Window
    {
        public Marka()
        {
            InitializeComponent();
        }

        public Marka(System.Xml.XmlElement kategoria)
        {
            DataContext = kategoria;
            Console.WriteLine(kategoria);
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new SzczegułyOkno().Show();
        }
    }
}
