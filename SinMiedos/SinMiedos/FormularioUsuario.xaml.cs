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
using MaterialDesignThemes.Wpf;


namespace SinMiedos
{
    /// <summary>
    /// Lógica de interacción para FormularioUsuario.xaml
    /// </summary>
    public partial class FormularioUsuario : Page
    {
        

        public FormularioUsuario()
        {
            InitializeComponent();
        }
        private void DataGrid_Paciente(object sender, RoutedEventArgs e)
        {
            var items = new List<Paciente>();
           for (int i=1;i < 100;i++){
                items.Add(new Paciente(i,"Alejandro", "Ortiz", "Tetecatl",true));
            }
                var grid = sender as DataGrid;
            grid.ItemsSource = items;
        }

        private void Sample1_DialogHost_OnDialogClosing(object sender, DialogClosingEventArgs eventArgs)
        {
            Console.WriteLine("SAMPLE 1: Closing dialog with parameter: " + (eventArgs.Parameter ?? ""));
                    

            if (!Equals(eventArgs.Parameter, true)) return;

            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                Console.WriteLine(txtNombre.Text);
            }
                
        }

        private void EliminarA(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Deseas eliminar al paciente?",
                                          "Eliminar Paciente",
                                          MessageBoxButton.YesNo,
                                          MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Console.WriteLine("Eilinado");
            }          
        }
        
    }

}
