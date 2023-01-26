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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Osszeadas(object sender, RoutedEventArgs e)
        {
            string eredmeny = $"{txtAszam.Text} + {txtBszam.Text} = {(Convert.ToDouble(txtAszam.Text) + Convert.ToDouble(txtBszam.Text))}";
            MessageBox.Show(eredmeny);
            lberedmenyek.Items.Add(eredmeny);
        }

        private void Kivonas(object sender, RoutedEventArgs e)
        {
            string eredmeny = $"{txtAszam.Text} - {txtBszam.Text} = {(Convert.ToDouble(txtAszam.Text) - Convert.ToDouble(txtBszam.Text))}";
            MessageBox.Show(eredmeny);
            lberedmenyek.Items.Add(eredmeny);
        }

        private void Szorzas(object sender, RoutedEventArgs e)
        {
            string eredmeny = $"{txtAszam.Text} * {txtBszam.Text} = {(Convert.ToDouble(txtAszam.Text) * Convert.ToDouble(txtBszam.Text))}";
            MessageBox.Show(eredmeny);
            lberedmenyek.Items.Add(eredmeny);
        }

        private void Osztas(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(txtBszam.Text) == 0)
            {
                MessageBox.Show("0-val nem lehet osztani!");
            }
            else
            {
                string eredmeny = $"{txtAszam.Text} / {txtBszam.Text} = {(Convert.ToDouble(txtAszam.Text) / Convert.ToDouble(txtBszam.Text))}";
                MessageBox.Show(eredmeny);
                lberedmenyek.Items.Add(eredmeny);
            }
        }
    }
}
