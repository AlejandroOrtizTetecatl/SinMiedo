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
using System.IO;
using System.Windows.Threading;


namespace SinMiedos
{
    /// <summary>
    /// Lógica de interacción para VentanMenu.xaml
    /// </summary>
    public partial class VentanMenu : Window
    {
        String usuario;

        public VentanMenu(String Nombre, String TipoUsuario)
        {
            InitializeComponent();
            txtUsuario.Text = Nombre;
            txtadministrador.Text = TipoUsuario;
            btnNormal.Visibility = Visibility.Hidden;
            OcultarBotones();
        }

        private void OcultarBotones()
        {
            String Tipo = txtadministrador.Text;
            Console.WriteLine("El Tipo Es"+Tipo);
            if (Tipo == "administrador")
            {
                btnDoctor.Visibility = Visibility.Visible;
                btnPaciente.Visibility = Visibility.Hidden;
                btnMonitoreo.Visibility = Visibility.Hidden;
                btnReporte.Visibility = Visibility.Hidden;
            }
            if(Tipo == "doctor")
            {
                btnDoctor.Visibility = Visibility.Collapsed;
                btnPaciente.Visibility = Visibility.Visible;
                btnMonitoreo.Visibility = Visibility.Visible;
                btnReporte.Visibility = Visibility.Visible;

            }
        }

        private void Menu_load(object sender, EventArgs e)
        {
            txtUsuario.Text = Convert.ToString(usuario);
        }
        private void Salir(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Deseas salir de la aplicación?",
                                         "Salir",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void Minimizar(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
            
        }

        private void Maximizar(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
            btnNormal.Visibility = Visibility.Visible;
            btnMaximizar.Visibility = Visibility.Hidden;

        }
        private void Normal(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
            btnMaximizar.Visibility = Visibility.Visible;
            btnNormal.Visibility = Visibility.Hidden;
        }

        private void Mover(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void NavegacionUsuario(object sender, RoutedEventArgs e)
        {
            Contenedor.Source = new Uri("FormularioUsuario.xaml", UriKind.Relative);
        }

        private void NavegacionMonitoreo(object sender, RoutedEventArgs e)
        {
            Contenedor.Source = new Uri("PaginaDeMonitoreo.xaml", UriKind.Relative);

        }

        private void NavegacionReporte(object sender, RoutedEventArgs e)
        {
            Contenedor.Source = new Uri("PaginaDeReportes.xaml", UriKind.Relative);

        }

        private void NavegacionDoctor(object sender, RoutedEventArgs e)
        {
            Contenedor.Source = new Uri("FormularioDoctor.xaml", UriKind.Relative);

        }

    }

}
