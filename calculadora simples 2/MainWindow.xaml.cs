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

namespace calculadora_simples_2
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

        private void btnsomar_click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtNumero1.Text);
            int y = int.Parse(txtNumero2.Text);
            int result = x + y;
            MessageBox.Show("O resultado da soma é " + result);
        }

        private void btnsubtrair_click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtNumero1.Text);
            int y = int.Parse(txtNumero2.Text);
            int result = x - y;
            MessageBox.Show("O resultado da subtração é " + result);
        }

        private void btnmultiplica_click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtNumero1.Text);
            int y = int.Parse(txtNumero2.Text);
            int result = x * y;
            MessageBox.Show("O resultado da multiplicação é " + result);
        }

        private void btndividir_click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtNumero1.Text);
            int y = int.Parse(txtNumero2.Text);
            int result = x / y;
            MessageBox.Show("O resultado da divisão é " + result);
        }

        private void btnlimpar_click(object sender, RoutedEventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
        }
    }
}
