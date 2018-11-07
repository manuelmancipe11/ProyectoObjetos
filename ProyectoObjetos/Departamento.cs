using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoObjetos
{

    public class Departamento
    {
        

        public String nombre { get; set; }
        public String capital { get; set; }
        public int poblacion { get; set; }

        public Departamento(string nombre, string capital, int poblacion)
        {
            this.nombre = nombre;
            this.capital = capital;
            this.poblacion = poblacion;
        }
    }
}
