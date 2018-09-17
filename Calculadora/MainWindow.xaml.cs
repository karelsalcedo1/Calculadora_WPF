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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long numero1 = 0;
        long numero2 = 0;
        string operacion = "";
       

        public MainWindow()
        {
            InitializeComponent();
          
        }

  

        private void btnac(object sender, RoutedEventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operacion = "";
            Pantalla.Content = "0";
        }

        private void btnmasmenos(object sender, RoutedEventArgs e)
        {
            //Pantalla.Content = (-1 * int.Parse(Pantalla.ToString).ToString);
        }

        private void btnmodulo(object sender, RoutedEventArgs e)
        {
            operacion = "%";
            Pantalla.Content = "0";
        }

        private void btndivision(object sender, RoutedEventArgs e)
        {
            operacion = "/";
            Pantalla.Content = "0";
        }

        private void num7(object sender, RoutedEventArgs e)
        {
            if(operacion == "")
            {
                numero1 = (numero1 * 10) + 7;
                Pantalla.Content = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 7;
                Pantalla.Content = numero2.ToString();
            }
        }

        private void num8(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 8;
                Pantalla.Content = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 8;
                Pantalla.Content = numero2.ToString();
            }
        }

        private void num9(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 9;
                Pantalla.Content = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 9;
                Pantalla.Content = numero2.ToString();
            }
        }

        private void btnmultipicar(object sender, RoutedEventArgs e)
        {
            operacion = "*";
            Pantalla.Content = "0";
        }

        private void num4(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 4;
                Pantalla.Content = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 4;
                Pantalla.Content = numero2.ToString();
            }
        }

        private void num5(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 5;
                Pantalla.Content = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 5;
                Pantalla.Content = numero2.ToString();
            }
        }

        private void num6(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 6;
                Pantalla.Content = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 6;
                Pantalla.Content = numero2.ToString();
            }
        }

        private void btnmenos(object sender, RoutedEventArgs e)
        {
            operacion = "-";
            Pantalla.Content = "0";
        }

        private void num1(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 1;
                Pantalla.Content = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 1;
                Pantalla.Content = numero2.ToString();
            }
        }

        private void num2(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 2;
                Pantalla.Content = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 2;
                Pantalla.Content = numero2.ToString();
            }
        }

        private void num3(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 3;
                Pantalla.Content = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 3;
                Pantalla.Content = numero2.ToString();
            }
        }

        private void btnmas(object sender, RoutedEventArgs e)
        {
            operacion = "+";
            Pantalla.Content = "0";
        }

        private void num0(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 0;
                Pantalla.Content = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 0;
                Pantalla.Content = numero2.ToString();
            }
        }

        private void btnpunto(object sender, RoutedEventArgs e)
        {
          //string dato = string Parse(Pantalla.Content);
        }

        private void btnigual(object sender, RoutedEventArgs e)
        {
            switch(operacion)
            {
                case "+":
                    Pantalla.Content = (numero1 + numero2).ToString();
                break;
                case "-":
                    Pantalla.Content = (numero1 - numero2).ToString();
                break;
                case "*":
                    Pantalla.Content = (numero1 * numero2).ToString();
                break;
                case "/":
                    Pantalla.Content = (numero1 / numero2).ToString();
                break;
                case "%":
                    Pantalla.Content = (numero1 % numero2).ToString();
                break;
            }
            numero1 = 0;
            numero2 = 0;
            operacion = "";
        }
    }
}
