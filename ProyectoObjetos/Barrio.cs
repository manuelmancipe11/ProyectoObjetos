using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoObjetos
{
    public class Barrio
    {

        private String nombre { get; set; }
        private String localidad { get; set; }
        private int poblacion { get; set; }

        public Barrio(string nombre, string localidad, int poblacion)
        {
            this.nombre = nombre;
            this.localidad = localidad;
            this.poblacion = poblacion;
        }
    }

}
