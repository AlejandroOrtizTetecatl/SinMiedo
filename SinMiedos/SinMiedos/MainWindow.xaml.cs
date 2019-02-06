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
           // MessageBox.Show(contra);

            VentanMenu menu = new VentanMenu();
            menu.Owner = this;
            menu.Show();
            this.Hide();

        
        }
    }
}
