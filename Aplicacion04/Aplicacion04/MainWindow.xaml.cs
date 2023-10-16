using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Aplicacion04
{

    public partial class MainWindow : Window
    {
        public ObservableCollection<Persona> listaPersonas { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            listaPersonas = new ObservableCollection<Persona>();
            listaPersonas.Add(new Persona("Twilight", "Sparkle"));
            listaPersonas.Add(new Persona("Pinkie"
           , "Pie"));
            listaPersonas.Add(new Persona("Flutter"
           ,
           "Shy"));
            listaPersonas.Add(new Persona("Rainbow", "Dash"));
            listaPersonas.Add(new Persona("Rari"
           , "Ty"));
            listaPersonas.Add(new Persona("Apple", "Jack"));
            listaPersonas.Add(new Persona("Apple", "Bloom"));
            listaPersonas.Add(new Persona("Granny"
           , "Smith"));
            listaPersonas.Add(new Persona("Big", "Mac"));
            this.DataContext = this;
        }

        private void botonAnadir_Click(object sender, RoutedEventArgs e)
        {
            listaPersonas.Add(new Persona("Tipode","Incognito"));
        }
    }
















    public class Persona
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public override string ToString()
        {
            return Nombre +" "+ Apellido;
        }
    }
}
