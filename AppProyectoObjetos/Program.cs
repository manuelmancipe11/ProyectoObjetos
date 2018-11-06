using ProyectoObjetos;
using System;

namespace AppProyectoObjetos
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Metodo m = new Metodo();
            Console.WriteLine(@"Hola: que deseas hacer?
                1. Ver Dertamentos
                2. Ver Ciudades
                3. Ver Barrios
                4. Ver Barrios");

            int opc;
            opc= int.Parse(Console.ReadLine());

            switch (opc)

            {
                case 1:
                    Console.WriteLine(@"Hola: que deseas hacer?
                1. Agregar departamento
                2. Eliminar departamento
                3. Ver departamentos");
                    int opc2;
                    opc2 = int.Parse(Console.ReadLine());
                    if (opc2 == 1)
                    {
                        Console.WriteLine(@"Ingresa nombre");
                        String nombre1=Console.ReadLine();
                        Console.WriteLine(@"Ingresa capital");
                        String capital=Console.ReadLine();
                        Console.WriteLine(@"Ingresa poblacion");
                        int poblacion;
                        poblacion = int.Parse(Console.ReadLine());
                        m.AgregarDepartamento(nombre1, capital, poblacion);
                    }
                    break;

            }

                Console.ReadKey();
        }
    }
}
