using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProyectoObjetos
{
        class Metodo
    {
        Departamento departamento = new Departamento();
        Ciudad ciudad = new Ciudad();
        Barrio barrio = new Barrio();
        Persona persona = new Persona();
    
        List<Departamento> departamentos= new List <Departamento>();
        List<Ciudad> ciudades = new List<Ciudad>();
        List<Barrio> barrios = new List<Barrio>();
        List<Persona> personas = new List<Persona>();



        public void AgregarDepartamento(String nombre, String capital, int poblacion)
        {
            Departamento departamentoNuevo = new Departamento(nombre, capital,poblacion);
            departamentos.Add(departamentoNuevo);

        }

    }
}
