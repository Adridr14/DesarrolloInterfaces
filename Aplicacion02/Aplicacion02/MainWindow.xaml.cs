using Aplicacion02.datos;
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

namespace Aplicacion02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(new Persona("Terry", "Jeffords"));
            listaPersonas.Add(new Persona("Rosa", "Díaz"));
            listaPersonas.Add(new Persona("Jake", "Peralta"));
            listaPersonas.Add(new Persona("Amy", "Santiago"));
            listaPersonas.Add(new Persona("Gina", "Linetti"));
            listaPersonas.Add(new Persona("Raymond", "Jacob Hott"));
            listaPersonas.Add(new Persona("Charles", "Boyle"));
            listaPersonas.Add(new Persona("Doug", "Judy"));
            foreach (Persona persona in listaPersonas)
            {
                ComboBoxItem cbi = new ComboBoxItem();
                cbi.Content = persona;
                comboPrueba.Items.Add(cbi);
            }

        }

        private void comboPrueba_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)comboPrueba.SelectedItem;
            Persona persona = (Persona)cbi.Content;
            labelNombre.Content = persona.Nombre;
            labelApellidos.Content = persona.Apellidos;
        }
    }
}
