
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

namespace AplicacionComboBoxyEventos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
         
                InitializeComponent();
                List<String> listaOpcion = new List<String>();
                listaOpcion.Add("Esta viendo el texto de Opcion1");
                listaOpcion.Add("Esta viendo el texto de Opcion2");
                listaOpcion.Add("Esta viendo el texto de Opcion3");
                listaOpcion.Add("Esta viendo el texto de Opcion4");
               
                foreach (String opcion in listaOpcion)
                {
                    ComboBoxItem cbi = new ComboBoxItem();
                    cbi.Content = opcion;
                    comboOpcion.Items.Add(cbi);
                }

            }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            
            if (comboOpcion.SelectedItem != null)
            {
                ComboBoxItem cbi = (ComboBoxItem)comboOpcion.SelectedItem;
               
                labelTexto.Content = cbi.Content;
            }
            else
            {
                labelTexto.Content = "Debe seleccionar una opción";

            }
        }

    }
 }
    

