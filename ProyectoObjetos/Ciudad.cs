using System;

namespace ProyectoObjetos
{
    public class Ciudad
    {
        

        public String nombre { get; set; }
        public int extension { get; set; }
        public int poblacion { get; set; }

        public Ciudad(string nombre, int extension, int poblacion)
        {
            this.nombre = nombre;
            this.extension = extension;
            this.poblacion = poblacion;
        }
    }
}
