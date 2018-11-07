using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoObjetos
{
    public class Persona
    {
        public Persona(string nombre, string profesion, int id)
        {
            this.nombre = nombre;
            this.profesion = profesion;
            this.id = id;
        }

        public String nombre { get; set; }
        public String profesion { get; set; }
        private int id { get; set; }
    }
}
