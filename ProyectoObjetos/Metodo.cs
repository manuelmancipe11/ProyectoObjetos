using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoObjetos
{
    public class Metodo
    {
        public bool NumberValidation(int entrada)
        {
            bool esEntero = Int32.TryParse(Console.ReadLine(), out entrada);
            if (!esEntero)
            {
                return false;
            }
            return true;
        }

        public void AgregarDepartamento(List<Departamento> departamentos, String nombre, String capital, int poblacion)
        {
            Departamento nuevoDepartamento = new Departamento(nombre, capital, poblacion);
            departamentos.Add(nuevoDepartamento);

        }

        public void AgregarCiudad(List<Ciudad> ciudades, String nombre, int extencion, int poblacion)
        {
            Ciudad nuevaCiudad = new Ciudad(nombre, extencion, poblacion);
            ciudades.Add(nuevaCiudad);

        }

        public void AgregarBarrio(List<Barrio> barrios, String nombre, String localidad, int poblacion)
        {
            Barrio nuevoBarrio = new Barrio(nombre, localidad, poblacion);
            barrios.Add(nuevoBarrio);

        }

        public void AgregarPersona(List<Persona> personas, String nombre, String profesion, int edad)
        {
            Persona nuevaPersona = new Persona(nombre, profesion, edad);
            personas.Add(nuevaPersona);

        }

        public void EliminarDepartamento(List<Departamento> departamentos, int indexD)
        {

            departamentos.RemoveAt(indexD);

        }

        public void EliminarCiudad(List<Ciudad> ciudades, int indexC)
        {
            ciudades.RemoveAt(indexC);

        }

        public void EliminarBarrio(List<Barrio> barrios, int indexB)
        {
            barrios.RemoveAt(indexB);

        }
        public void EliminarPersona(List<Persona> personas, int indexP)
        {
            personas.RemoveAt(indexP);

        }

        public void VerDepartamentos(List<Departamento> departamentos)
        {
            if (departamentos.Count<1)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else { 
            for (int i = 0; i < departamentos.Count; i++)
            {
                Departamento departamento = departamentos[i];
                Console.WriteLine(i+". "+departamento.nombre);
            }
            }
        }

        public void Verciudades(List<Ciudad> ciudades)
        {
            if (ciudades.Count < 1)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                for (int i = 0; i < ciudades.Count; i++)
                {
                    Ciudad ciudad = ciudades[i];
                    Console.WriteLine(i + ". " + ciudad.nombre);
                }
            }
        }

        public void VerBarrios(List<Barrio> barrios)
        {
            if (barrios.Count < 1)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                for (int i = 0; i < barrios.Count; i++)
                {
                    Barrio barrio = barrios[i];
                    Console.WriteLine(i + ". " + barrio.nombre);
                }
            }
        }

        public void VerPersonas(List<Persona> personas)
        {
            if (personas.Count < 1)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                for (int i = 0; i < personas.Count; i++)
                {
                    Persona persona = personas[i];
                    Console.WriteLine(i + ". " + persona.nombre);
                }
            }

        }
        public int MostrarPrimerMenu()
        {
            Console.WriteLine(@"Hola: que deseas hacer?
                1. - Dertamentos -
                2. - Ciudades -
                3. - Barrios -
                4. - Personas -
                5. SALIR!!!");
            int opc = int.Parse(Console.ReadLine());
           

            return opc;

        }

    }

}
