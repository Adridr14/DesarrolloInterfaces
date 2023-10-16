using Practica02Wpf.datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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


namespace Practica02Wpf
{
    public partial class MainWindow : Window
    {

        public ObservableCollection<Tarea> ListaFinal { get; set; }
        
        
        public MainWindow()
        {
            InitializeComponent();
            ListaFinal = new ObservableCollection<Tarea>();
            
            addCategoria.Items.Add( "Personal" );
            addCategoria.Items.Add("Proyecto");
            addCategoria.Items.Add("Examen");
            addCategoria.Items.Add("Exposición");
           
            this.DataContext = this;
           
          

        }

        private void addTarea_Click(object sender, RoutedEventArgs e) {
            String nombre = addNombre.Text;
            String categ = (String)addCategoria.SelectedItem;
            if (addNombre.Text .Equals("")) {
                nombre = "Sin Título";
            }
            ListaFinal.Add(new Tarea(nombre, categ));
            addNombre.Text = null;
        }

        private void delTarea_Click_1(object sender, RoutedEventArgs e)
        {
            ListaFinal.Remove((Tarea)lisTareas.SelectedItem);

        }
    }
}
