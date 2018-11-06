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
            Departamento nuevoDepartamento = new Departamento(nombre, capital,poblacion);
            departamentos.Add(nuevoDepartamento);

        }

        public void AgregarCiudad(String nombre, int extencion, int poblacion)
        {
            Ciudad nuevaCiudad = new Ciudad(nombre, extencion, poblacion);
            ciudades.Add(nuevaCiudad);

        }

        public void AgregarBarrio(String nombre, String localidad, int poblacion)
        {
            Barrio nuevoBarrio = new Barrio(nombre, localidad, poblacion);
            barrios.Add(nuevoBarrio);

        }
    
        public void AgregarPersona(String nombre, String profesion, int edad)
        {
            Persona nuevaPersona= new Persona(nombre, profesion, edad);
            personas.Add(nuevaPersona);

        }

        public void EliminarDepartamento(Departamento departamento)
        {
            departamentos.Remove(departamento);

        }

        public void EliminarCiudad(Ciudad ciudad)
        {
            ciudades.Remove(ciudad);

        }

        public void EliminarBarrio(Barrio barrio)
        {
            barrios.Remove(barrio);

        }
        public void EliminarPersona(Persona persona)
        {   
            personas.Remove(persona);

        }

    }
}
