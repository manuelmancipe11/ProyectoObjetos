using System;

namespace ProyectoObjetos
{
    public class Ciudad
    {
        

        private String nombre { get; set; }
        private int extension { get; set; }
        private int poblacion { get; set; }

        public Ciudad(string nombre, int extension, int poblacion)
        {
            this.nombre = nombre;
            this.extension = extension;
            this.poblacion = poblacion;
        }
    }
}
