using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoObjetos
{
    public class Barrio
    {

        public String nombre { get; set; }
        public String localidad { get; set; }
        public int poblacion { get; set; }

        public Barrio(string nombre, string localidad, int poblacion)
        {
            this.nombre = nombre;
            this.localidad = localidad;
            this.poblacion = poblacion;
        }
    }

}
