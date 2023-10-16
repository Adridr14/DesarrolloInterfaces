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

namespace Practica03_TresEnRaya
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EvtPonerFicha(object sender, RoutedEventArgs e)
        {
            int turno = 1;
            Button btn = (Button)sender;
            if (turno %2 ==0) {
                btn.Content=
            }
            else if (turno %2 !=0) { 
            
            }
        }
    }
}
