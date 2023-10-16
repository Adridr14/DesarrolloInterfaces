using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02Wpf.datos
{
    public class Tarea
    {
        public String nombre;
        public String categoria { get; set; }

        public Tarea(String nombre, String categoria) {
            this.nombre = nombre;
            this.categoria = categoria;
        }
        public void setNombre(String nombre) {
            this.nombre = nombre;
        }
        public String getNombre() {
            return nombre;
        }
        public override String ToString() {
            return nombre + " " + categoria;
        }
    }
}
