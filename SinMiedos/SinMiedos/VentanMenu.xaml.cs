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

        public VentanMenu(String Nombre)
        {
            InitializeComponent();
            txtUsuario.Text = Nombre;
          
        }


        private void Menu_load(object sender, EventArgs e)
        {
            txtUsuario.Text = Convert.ToString(usuario);
        }
        private void Salir(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void Minimizar(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;


        }

        private void Maximizar(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
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

 
    }

}
