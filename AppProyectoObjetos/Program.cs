using ProyectoObjetos;
using System;

namespace AppProyectoObjetos
{
    public class Program
    {

        static void Main(string[] args)
        {
            Metodo m = new Metodo();


            int opc = m.MostrarPrimerMenu();


            switch (opc)
            {
                case 1:
                    Console.WriteLine(@"...DEPARTAMENTOS...
                     1. Agregar un departamento
                     2. Eliminar un departamento
                     3. Ver todos los departamentos");

                    int opc2 = int.Parse(Console.ReadLine());

                    switch (opc2)
                    {
                        case 1:
                            Console.WriteLine(@"...DEPARTAMENTOS...");
                            Console.WriteLine("Ingrese departamento");
                            String nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese capital");
                            String capital = Console.ReadLine();
                            Console.WriteLine("Ingrese numero de habitantes");
                            int poblacion = int.Parse(Console.ReadLine());
                            m.AgregarDepartamento(nombre, capital, poblacion);
                            break;

                        case 2:

                            Console.WriteLine(@"...DEPARTAMENTOS...");
                            m.VerDepartamentos();                 
                            Console.WriteLine("digite el numero del departamento que desea eliminar");
                            int dptoEliminar = int.Parse(Console.ReadLine());                    
                            m.EliminarDepartamento(dptoEliminar);
                            break;

                        case 3:

                            Console.WriteLine(@"...DEPARTAMENTOS...");
                            m.VerDepartamentos();
                            break;





                    }

                case 2:
                    Console.WriteLine(@"...CIUDADES...
                     1. Agregar una ciudad
                     2. Eliminar una Ciudad
                     3. Ver todos las ciudades");

                    int opc3 = int.Parse(Console.ReadLine());

                    switch (opc3)
                    {
                        case 1:
                            Console.WriteLine(@"...CIUDADES...");
                            Console.WriteLine("Ingrese nombre de la Ciudad");
                            String nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese extension (en km²)");
                            int extension = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese numero de habitantes");
                            int poblacion = int.Parse(Console.ReadLine());
                            m.AgregarCiudad(nombre, extension, poblacion);
                            break;

                        case 2:
                            Console.WriteLine(@"...CIUDADES...");
                            m.Verciudades();
                            Console.WriteLine("digite el numero de la ciudad que desea eliminar");
                            int ciudadEliminar = int.Parse(Console.ReadLine());
                            m.EliminarCiudad(ciudadEliminar);
                            break;


                    }




                    break;

                    
                    




            }





            Console.ReadKey();
        }
    }
}




