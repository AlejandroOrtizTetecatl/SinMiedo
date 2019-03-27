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
using System.Text.RegularExpressions;


namespace SinMiedos
{
    public partial class FormularioUsuario : Page
    {
        DAOPaciente pacientes = new DAOPaciente();
        String Nombre;
        String Paterno;
        String Materno;
        int Edad;
        String Telefono;
        String Direccion;
        String Email;
        Char Sexo;
        int IdPersona;
        bool Permiso = true;

        public FormularioUsuario()
        {
            InitializeComponent();

        }
        private void DataGrid_Paciente(object sender, RoutedEventArgs e)
        {           

            var grid = sender as DataGrid;
            grid.ItemsSource = pacientes.DatosPaciente();
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
                Paciente pa = DataGrid.SelectedItem as Paciente;
                int  Pacienteid = pa.Id;
                if (pacientes.EliminarPaciente(Pacienteid)){

                    MessageBox.Show("Paciente eliminado correctamente", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                    DataGrid.ItemsSource = pacientes.DatosPaciente();

                }
                else
                {
                    MessageBox.Show("Oops, algo salió mal ...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }

            }          
        }
        private void Agregar(object sender, RoutedEventArgs e)
        {
            if (Permiso)
            {
                AgregarPaciente();
            }
            else
            {
                EditarPaciente();
            }
        }

        private void AgregarPaciente()
        {
            Nombre = txtNombre.Text;
            Paterno = txtPaterno.Text;
            Materno = txtMaterno.Text;
            Telefono = txtTelefono.Text;
            Direccion = txtDireccion.Text;
            Email = txtEmail.Text;
            int indice = cmbSexo.SelectedIndex;
            Sexo = indice == 0 ? 'F' : 'M';
            
            if (IsValidarEdad(txtEdad.Text))
            {
                Edad = int.Parse(txtEdad.Text);
            }
            else
            {
                MessageBox.Show("EdadInvalida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (Validar())
            {
                pacientes.AgregarPaciente(Nombre, Paterno, Materno, Edad, Telefono, Direccion, Email, Sexo);

                MessageBox.Show("Paciente Agregado correctamente");
                DataGrid.ItemsSource = pacientes.DatosPaciente();
            }
            else {
                MessageBox.Show("Existen campos vacios", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        public static bool IsValidEmailAddress(string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }


        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^([0-9]{10})$").Success;
        }


        public static bool IsValidarEdad(string edad)
        {
            int edadint = int.Parse(edad);
            if (edadint > 0 & edadint < 100)
            {
                return Regex.Match(edad, @"^([0-9]{2})$").Success;
            }
            else
            {
                return false;
            }
        }


        private bool Validar()
        {
            bool validarEmail = IsValidEmailAddress(Email);
            bool validarTelefono = IsPhoneNumber(Telefono);

            if (Nombre.Length == 0)
            {
                return false;
            }
            if (Paterno.Length == 0)
            {
                return false;
            }
            if (Materno.Length == 0)
            {
                return false;
            }
            if (Direccion.Length == 0)
            {
                return false;
            }
            if (Telefono.Length == 0)
            {
                return false;
            }
            if (Edad == 0)
            {
                return false;
            }
            if (Email.Length == 0)
            {
                return false;
            }
            if (!validarEmail)
            {
                MessageBox.Show("Correo incorrecto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (!validarEmail)
            {
                MessageBox.Show("Telefono incorrecto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void EditarPaciente()
        {
            Nombre = txtNombre.Text;
            Paterno = txtPaterno.Text;
            Materno = txtMaterno.Text;
            Telefono = txtTelefono.Text;
            Direccion = txtDireccion.Text;
            Email = txtEmail.Text;
            IdPersona = int.Parse(txtidPaciente.Text);
            int indice = cmbSexo.SelectedIndex;
            Sexo = indice == 0 ? 'F' : 'M';
            Edad = txtEdad.Text == "" ? 0 : Edad = int.Parse(txtEdad.Text);
            Boolean respuesta =  pacientes.Editar(IdPersona,Nombre,Paterno,Materno,Telefono,Direccion,Email, Sexo, Edad);
            if (respuesta)
            {
                MessageBox.Show("Paciente Editado Correctamente", "Aviso: ", MessageBoxButton.OK, MessageBoxImage.Information);
                DataGrid.ItemsSource = pacientes.DatosPaciente(); 
            }
            else
            {
                MessageBox.Show("Oops, algo salió mal ...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EditarA(object sender, RoutedEventArgs e)
        {
                Permiso = false;

                Paciente pa = DataGrid.SelectedItem as Paciente;
                int Pacienteid = pa.Id;

                List<Paciente> items = pacientes.EditarPaciente(Pacienteid);
                foreach (var item in items)
                {
                    txtNombre.Text = item.Nombre;
                    txtPaterno.Text = item.Paterno;
                    txtMaterno.Text = item.Materno;
                    txtTelefono.Text = item.Telefono;
                    txtDireccion.Text = item.Direccion;
                    txtEmail.Text = item.Email;
                    txtEdad.Text = "" + item.Edad;
                    txtidPaciente.Text = "" + item.Id;
                    char sexo = item.Sexo ;
                    cmbSexo.SelectedIndex = sexo == 'F' ? 0 : 1;
                }
            
        }

        private void Modal(object sender, RoutedEventArgs e)
        {
            Permiso = true;
            txtNombre.Text ="";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtEdad.Text = "";
            txtidPaciente.Text = "";
        }
    }

}
