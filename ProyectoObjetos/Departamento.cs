using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoObjetos
{

    public class Departamento
    {
        

        private String nombre { get; set; }
        private String capital { get; set; }
        private int poblacion { get; set; }

        public Departamento(string nombre, string capital, int poblacion)
        {
            this.nombre = nombre;
            this.capital = capital;
            this.poblacion = poblacion;
        }
    }
}
