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

namespace SinMiedos
{
    /// <summary>
    /// Lógica de interacción para VentanMenu.xaml
    /// </summary>
    public partial class VentanMenu : Window
    {
        public VentanMenu()
        {
            InitializeComponent();
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
        private void Mover(object sender,MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
