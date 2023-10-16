namespace Aplicacion04
{
    public class Persona
    {
        private string nombre { get; set; }
        private string apellido { get; set; }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public override string ToString() { 
        return nombre+" "+apellido;
        }
    }
}