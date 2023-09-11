
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
    /// Lógica de interacción para EcuacionLineal.xaml
    /// </summary>
    public partial class EcuacionLineal : Window
    {

        


        public EcuacionLineal()
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

            if(txtX.Text == "")
            {
                MessageBox.Show("Necesitas llenar el valor de X");
                return;
            }
            if (txtX1.Text == "")
            {
                MessageBox.Show("Necesitas llenar el valor de X1");
                return;
            }
            if (txtX2.Text == "")
            {
                MessageBox.Show("Necesitas llenar el valor de X2");
                return;
            }
            if (txtY1.Text == "")
            {
                MessageBox.Show("Necesitas llenar el valor de Y1");
                return;
            }
            if (txtY2.Text == "")
            {
                MessageBox.Show("Necesitas llenar el valor de Y2");
                return;
            }

            float x = float.Parse(txtX.Text);
            float x1= float.Parse(txtX1.Text);
            float x2 = float.Parse(txtX2.Text);
            float y1 = float.Parse(txtY1.Text);
            float y2 = float.Parse(txtY2.Text);
            float Y;
  
            Y = ((y2 - y1) / (x2 - x1)) * (x - x1) + y1;


            lblResultadoY.Content = Y.ToString();
            lblResultadoX.Content = x.ToString();

        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            EscogerEcuacion Escoger = new EscogerEcuacion();
            this.Hide();
            Escoger.Show();
        }
    }
}

