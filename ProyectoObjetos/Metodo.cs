using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProyectoObjetos
{
    public class Metodo
    {


        List<Departamento> departamentos = new List<Departamento>();
        List<Ciudad> ciudades = new List<Ciudad>();
        List<Barrio> barrios = new List<Barrio>();
        List<Persona> personas = new List<Persona>();



        public void AgregarDepartamento(String nombre, String capital, int poblacion)
        {
            Departamento nuevoDepartamento = new Departamento(nombre, capital, poblacion);
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
            Persona nuevaPersona = new Persona(nombre, profesion, edad);
            personas.Add(nuevaPersona);

        }

        public void EliminarDepartamento(int indexD)
        {

            departamentos.RemoveAt(indexD);

        }

        public void EliminarCiudad(int indexC)
        {
            ciudades.RemoveAt(indexC);

        }

        public void EliminarBarrio(int indexB)
        {
            barrios.RemoveAt(indexB);

        }
        public void EliminarPersona(int indexP)
        {
            personas.RemoveAt(indexP);

        }

        public void VerDepartamentos()
        {
            for (int i = 0; i <= departamentos.Count; i++)
            {
               Console.WriteLine(i+". "+departamentos[i]);

            }

        }

        public void Verciudades()
        {
            for (int i = 0; i <= ciudades.Count; i++)
            {
                Console.WriteLine(ciudades[i]);

            }

        }

        public void VerBarrios()
        {
            for (int i = 0; i <= barrios.Count; i++)
            {
                Console.WriteLine(barrios[i]);

            }

        }

        public void VerPersonas()
        {
            for (int i = 0; i <= personas.Count; i++)
            {
                Console.WriteLine(personas[i]);

            }

        }

        public int MostrarPrimerMenu()
        {
            Console.WriteLine(@"Hola: que deseas hacer?
                1. Ver Dertamentos
                2. Ver Ciudades
                3. Ver Barrios
                4. Ver Barrios");
            int opc = int.Parse(Console.ReadLine());

            return opc;
            
        }


        
    }
}
