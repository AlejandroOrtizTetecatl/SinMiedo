﻿using System;
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
    /// Lógica de interacción para PaginaDeMonitoreo.xaml
    /// </summary>
    public partial class PaginaDeMonitoreo : Page
    {

        public IList<DataPoint> Points { get; private set; }
        Random r = new Random();
        DAOPaciente daopaciente = new DAOPaciente();
        public PaginaDeMonitoreo()
       
        {
            InitializeComponent();
      
            List<Paciente> items = daopaciente.DatosPaciente();
            foreach (var item in items)
            {
                ComboPacientes.Items.Add(item.Nombre + " " + item.Paterno + " " + item.Materno);
            }


        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
 
            String value = ComboPacientes.SelectedItem.ToString();

            PlotModel model = new PlotModel();

            model.Title = "Monitoriando a paciente : "+value;

            LineSeries linea = new LineSeries();

            LineSeries linea2 = new LineSeries();

            for (int i = 0;i<10;i++)
            {
                linea.Points.Add(new DataPoint((i), Math.Pow(i,2)));
                linea2.Points.Add(new DataPoint((i), (Math.Pow(i,2)+10)));

            }

            linea.Title = "Alfa";
            linea2.Title = "Beta";


            linea.Color = OxyColor.FromRgb(byte.Parse(r.Next(0, 255).ToString()), byte.Parse(r.Next(0, 255).ToString()), byte.Parse(r.Next(0, 255).ToString()));
            linea2.Color = OxyColor.FromRgb(byte.Parse(r.Next(0, 255).ToString()), byte.Parse(r.Next(0, 255).ToString()), byte.Parse(r.Next(0, 255).ToString()));

            model.Series.Add(linea);
            model.Series.Add(linea2);

            Grafica.Model = model;

        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPausar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReiniciar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
