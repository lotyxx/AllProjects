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

namespace KalkulackaWpf
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

        public void vypocitejButton_Click(object sender, RoutedEventArgs e)
        {
            string operace = ComboBox.Text;
            double cislo1 = double.Parse(TextBox.Text);
            double cislo2 = double.Parse(TextBox1.Text);
            double vysledek = 0;

            // výpočet
            if (operace == "+")
                vysledek = cislo1 + cislo2;
            else if (operace == "-")
                vysledek = cislo1 - cislo2;
            else if (operace == "*")
                vysledek = cislo1 * cislo2;
            else if (operace == "/")
            {
                if (cislo2 != 0)
                {
                    vysledek = cislo1 / cislo2;
                    
                } else
                    MessageBox.Show("Nulou nelze dělit");
                
            }
            TextBlock3.Text = vysledek.ToString();
        }
    }
}
