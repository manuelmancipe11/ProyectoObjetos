using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoObjetos
{
    public class Persona
    {
        public Persona(string nombre, string profesion, int edad)
        {
            this.nombre = nombre;
            this.profesion = profesion;
            this.edad = edad;
        }

        private String nombre { get; set; }
        private String profesion { get; set; }
        private int edad { get; set; }
    }
}
