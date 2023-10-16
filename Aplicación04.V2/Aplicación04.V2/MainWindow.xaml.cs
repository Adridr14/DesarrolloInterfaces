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
            listaPersonas.Add(new Persona(addNombre.Text, addApellido.Text));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void botonBorrar_Click(object sender, RoutedEventArgs e)
        {
            
                String texto = delPers.Text;
            
            int n=Convert.ToInt32(texto);
                if(n>0 && n<=listaPersonas.Count )
                listaPersonas.Remove(listaPersonas[n-1]);
            
        }
    }
}