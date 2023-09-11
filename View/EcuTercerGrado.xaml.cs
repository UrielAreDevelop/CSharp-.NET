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
    /// <summary>
    /// Lógica de interacción para EcuTercerGrado.xaml
    /// </summary>
    public partial class EcuTercerGrado : Window
    {
        public EcuTercerGrado()
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

            if (txtXK.Text == "" || txtXN.Text == "" || txtX0.Text == "" || txtDeltaY0.Text == "" || txtDeltaCuaY0.Text == "" || txtDeltaCubiY0.Text == "")
            {
                MessageBox.Show("Faltan valores por llenar");
            }
            else
            {

                float k, yk;
                float xk = float.Parse(txtXK.Text);
                float xn = float.Parse(txtXN.Text);
                float x0 = float.Parse(txtX0.Text);
                float y0n = float.Parse(txtY0N.Text);
                float deltaY0 = float.Parse(txtDeltaY0.Text);
                float deltacua = float.Parse(txtDeltaCuaY0.Text);
                float deltacubi = float.Parse(txtDeltaCubiY0.Text);


                if (PrimeraMitad.IsChecked == true)
                {
                    k = (xk - x0) / (xn - x0);

                    yk = y0n + (k) * (deltaY0) + (k * (k - 1) * (deltacua) / (2 * 1)) + (k * (k - 1) * (k - 2) * (deltacubi) / (3 * 2 * 1));

                    lblResultadoX.Content = xk.ToString();
                    lblResultadoY.Content = yk.ToString();

                }
                else if (SegundaMitad.IsChecked == true)
                {
                    k = (xn - xk) / (xn - x0);

                    yk = y0n - (k) * (deltaY0) + (k * (k - 1) * (deltacua) / (2 * 1)) - (k * (k - 1) * (k - 2) * (deltacubi) / (3 * 2 * 1));

                    lblResultadoX.Content = xk.ToString();
                    lblResultadoY.Content = yk.ToString();
                }
                else
                {
                    MessageBox.Show(" Selecciona un valor (Primera o Segunda mitad) "); ;
                }
            }

        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            EscogerEcuacion Escoger = new EscogerEcuacion();
            this.Hide();
            Escoger.Show();
        }
    }
}
