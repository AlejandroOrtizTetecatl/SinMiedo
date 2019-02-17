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
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;


namespace SinMiedos
{
    /// <summary>
    /// Lógica de interacción para PaginaDeReportes.xaml
    /// </summary>
    public partial class PaginaDeReportes : Page
    {
        public PaginaDeReportes()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            String value = ((ComboBoxItem)ComboPacientes.SelectedItem).Content.ToString();

            PlotModel model = new PlotModel();

            model.Title = "Monitoriando a paciente : " + value;

            LineSeries linea = new LineSeries();

            LineSeries linea2 = new LineSeries();

            for (int i = 0; i < 10; i++)
            {
                linea.Points.Add(new DataPoint((i), Math.Pow(i, 2)));
                linea2.Points.Add(new DataPoint((i), (Math.Pow(i, 2) + 10)));

            }

            linea.Title = "Alfa";
            linea2.Title = "Beta";


            linea.Color = OxyColor.FromRgb(byte.Parse(r.Next(0, 255).ToString()), byte.Parse(r.Next(0, 255).ToString()), byte.Parse(r.Next(0, 255).ToString()));
            linea2.Color = OxyColor.FromRgb(byte.Parse(r.Next(0, 255).ToString()), byte.Parse(r.Next(0, 255).ToString()), byte.Parse(r.Next(0, 255).ToString()));

            model.Series.Add(linea);
            model.Series.Add(linea2);

            Grafica.Model = model;

        }
        
    }
       
}
