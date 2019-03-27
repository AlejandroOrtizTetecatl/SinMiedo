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
    /// <summary>
    /// Lógica de interacción para FormularioDoctor.xaml
    /// </summary>
    public partial class FormularioDoctor : Page
    {
        DAODoctor daodoctor = new DAODoctor();
        String Nombre;
        String Paterno;
        String Materno;
        int Edad;
        String Telefono;
        String Direccion;
        String Email;
        Char Sexo;
        String Cedula;
        String Usuario;
        String Contraseña;
        int IdPersona;
        bool Permiso = true;

        public FormularioDoctor()
        {
            InitializeComponent();
        }

        private void DataGridDoctor_Loaded(object sender, RoutedEventArgs e)
        {

            var grid = sender as DataGrid;
            grid.ItemsSource = daodoctor.DatosDoctores();

        }

        private void Sample1_DialogHost_OnDialogClosing(object sender, DialogClosingEventArgs eventArgs)
        {
            Console.WriteLine("SAMPLE 1: Closing dialog with parameter: " + (eventArgs.Parameter ?? ""));

            if (!Equals(eventArgs.Parameter, true)) return;

        }

        private void Modal(object sender, RoutedEventArgs e)
        {
            Permiso = true;
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtEdad.Text = "";
            txtIdDoctor.Text = "";
            txtCedula.Text = "";
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Deseas eliminar al paciente?","Eliminar Paciente",MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {

                Doctor doc = DataGridDoctor.SelectedItem as Doctor;

                int Doctorid=doc.Id;
                Console.WriteLine(Doctorid);
                if (daodoctor.ElimnarDoctor(Doctorid))
                {

                    MessageBox.Show("Paciente eliminado correctamente", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                    DataGridDoctor.ItemsSource = daodoctor.DatosDoctores();

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
                AgregarDoctor();
            }
            else
            {
                EditarDoctor();
            }
        }

        private void EditarDoctor()
        {
            Nombre = txtNombre.Text;
            Paterno = txtPaterno.Text;
            Materno = txtMaterno.Text;
            Telefono = txtTelefono.Text;
            Direccion = txtDireccion.Text;
            Email = txtEmail.Text;
            Cedula = txtCedula.Text;
            IdPersona = int.Parse(txtIdDoctor.Text);
            int indice = cmbSexo.SelectedIndex;
            Sexo = indice == 0 ? 'F' : 'M';
            Edad = txtEdad.Text == "" ? 0 : Edad = int.Parse(txtEdad.Text);

                if (daodoctor.EditarDoctor(IdPersona, Nombre, Paterno, Materno, Telefono, Direccion, Email, Sexo, Edad, Cedula))
                {

                    MessageBox.Show("Paciente editado Correctamente correctamente", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                    DataGridDoctor.ItemsSource = daodoctor.DatosDoctores();
                }
                else
                {
                    MessageBox.Show("Oops, algo salió mal ...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
        }

        private void AgregarDoctor()
        {
            Nombre = txtNombre.Text;
            Paterno = txtPaterno.Text;
            Materno = txtMaterno.Text;
            Telefono = txtTelefono.Text;
            Direccion = txtDireccion.Text;
            Email = txtEmail.Text;
            Cedula = txtCedula.Text;
            int indice = cmbSexo.SelectedIndex;
            Sexo = indice == 0 ? 'F' : 'M';
            Usuario = txtUsuario.Text;
            Contraseña = txtPassword.Password;

            if (IsValidarEdad(txtEdad.Text))
            {
                Edad = int.Parse(txtEdad.Text);
            }
            else
            {
                MessageBox.Show("EdadInvalida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (validar())
            {
                   if (daodoctor.AgregarDoctor(Nombre, Paterno, Materno, Edad, Telefono, Direccion, Email, Sexo, Cedula, Usuario, Contraseña)){

                        MessageBox.Show("Paciente agregado Correctamente correctamente", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                        DataGridDoctor.ItemsSource = daodoctor.DatosDoctores();
                        btnAgregarModal.Command = DialogHost.CloseDialogCommand;
                    }
                    else
                    {
                        MessageBox.Show("Oops, algo salió mal ...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
            }
            else
            {
                MessageBox.Show("Existen campos vacios", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }
        private void EditarA(object sender, RoutedEventArgs e)
        {
            Permiso = false;

            Doctor doc = DataGridDoctor.SelectedItem as Doctor;
            int Doctorid = doc.Id;
            
            List<Doctor> items = daodoctor.EditarA(Doctorid);

            foreach (var item in items)
            {
                txtNombre.Text = item.Nombre;
                txtPaterno.Text = item.Paterno;
                txtMaterno.Text = item.Materno;
                txtTelefono.Text = item.Telefono;
                txtDireccion.Text = item.Direccion;
                txtEmail.Text = item.Email;
                txtEdad.Text = "" + item.Edad;
                txtIdDoctor.Text = "" + item.Id;
                txtCedula.Text = item.Cedula;
                char sexo = item.Sexo;
                cmbSexo.SelectedIndex = sexo == 'F' ? 0 : 1;
            }

        }

        public static bool IsValidEmailAddress(string s){
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
            if (edadint>0 & edadint<100)
            {
                return Regex.Match(edad, @"^([0-9]{2})$").Success;
            }
            else
            {
                return false;
            }
        }

        public Boolean validar()
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
            if (Cedula.Length == 0)
            {
                return false;
            }
            if (Email.Length == 0)
            {
                return false;
            }
            if (Usuario.Length == 0)
            {
                return false;
            }
            if (Contraseña.Length == 0)
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
    }
}
