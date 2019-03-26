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

            if (daodoctor.EditarDoctor(IdPersona,Nombre,Paterno,Materno,Telefono,Direccion,Email,Sexo,Edad,Cedula))
            {

                MessageBox.Show("Paciente editado Correctamente correctamente", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);

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
            Edad = txtEdad.Text == "" ? 0 : Edad = int.Parse(txtEdad.Text);

            if (daodoctor.AgregarDoctor(Nombre,Paterno,Materno,Edad,Telefono,Direccion,Email,Sexo,Cedula))
            {

                MessageBox.Show("Paciente agregado Correctamente correctamente", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Oops, algo salió mal ...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

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
    }
}
