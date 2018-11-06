using System;

namespace ProyectoObjetos
{
    public class Ciudad
    {
        

        private String nombre { get; set; }
        private int extension { get; set; }
        private int edad { get; set; }

        public Ciudad(string nombre, int extension, int edad)
        {
            this.nombre = nombre;
            this.extension = extension;
            this.edad = edad;
        }
    }
}
