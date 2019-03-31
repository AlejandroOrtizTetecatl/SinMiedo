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
public partial class MainWindow : Window
    {
        public DAOUsuario daousuario = new DAOUsuario();
        public DAOPaciente pac = new DAOPaciente();


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
            if (user.Length > 20 || user.Length > 20 )
            {
                MessageBox.Show("Ingrese un usuario y contraseña correcto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Usuario.Text = "";
                Contrasenia.Password = "";
            }
            else
            {
             if( daousuario.validarDatos(user, contra))
                {
                    VentanMenu menu = new VentanMenu(user, daousuario.IdUsuario(user, contra));
                    menu.Owner = this;
                    menu.Show();
                    this.Hide();

                }
                else{
                    MessageBox.Show("Usuario y contraseña incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }            


            }



        }
    }
}
