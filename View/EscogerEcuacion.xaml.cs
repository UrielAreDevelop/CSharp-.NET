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

namespace ProblemarioMatematicas.View
{
    

    public partial class EscogerEcuacion : Window
    {
        public EscogerEcuacion()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {

            WindowState = WindowState.Minimized;
            
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();

        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {

            if (EcuLineal.IsChecked == true)
            {
                EcuacionLineal EcuLine = new EcuacionLineal();
                this.Hide();
                EcuLine.Show();
            }else if (EcuSegGrado.IsChecked == true)
            {
                EcuSegundoGrado EcuSegGra = new EcuSegundoGrado();
                this.Hide();
                EcuSegGra.Show();
            }else if (EcuTerGrado.IsChecked == true)
            {
                EcuTercerGrado EcuTerGra = new EcuTercerGrado();
                this.Hide();
                EcuTerGra.Show();
            }
            else
            {
                MessageBox.Show("No has elegido opcion");
            }
        }
    }
}
