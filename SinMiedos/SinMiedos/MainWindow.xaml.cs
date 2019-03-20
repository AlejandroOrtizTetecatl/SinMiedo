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


namespace SinMiedos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnIngresar(object sender, RoutedEventArgs e)
        {
            String user = Usuario.Text;
            String contra = Contrasenia.Password;
  
            if (string.IsNullOrWhiteSpace(Usuario.Text) || string.IsNullOrWhiteSpace(Contrasenia.Password) ){

                MessageBox.Show("Ingrese un usuario y contraseña", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
     
            }
            else
            {
                VentanMenu menu = new VentanMenu(user);
                menu.Owner = this;
                menu.Show();
                this.Hide();

            }



        }
    }
}
