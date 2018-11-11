using ProyectoObjetos;
using System;
using System.Collections.Generic;

namespace AppProyectoObjetos
{
    public class Program
    {


        static void Main(string[] args)
        {


            List<Departamento> departamentos = new List<Departamento>();
            List<Ciudad> ciudades = new List<Ciudad>();
            List<Barrio> barrios = new List<Barrio>();
            List<Persona> personas = new List<Persona>();

            
            int opcT = 0;

            while (opcT != 5) {

                while (opcT == 0)
                {
                    Metodo m = new Metodo();
                    int opc = m.MostrarPrimerMenu();
                    if (opc == 5)
                        {
                            opcT = 5;
                        }

                        switch (opc)
                        {
                            case 1:
                                Console.WriteLine(@"...DEPARTAMENTOS...
                     1. Agregar un departamento
                     2. Eliminar un departamento
                     3. Ver todos los departamentos
                     4. Volver al menu principal");

                                int opc2 = int.Parse(Console.ReadLine());
                            if(m.NumberValidation(opc2)==true)
                            {
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
                                        m.AgregarDepartamento(departamentos, nombre, capital, poblacion);
                                        Console.WriteLine("Ingreso correcto");

                                        break;

                                    case 2:

                                        Console.WriteLine(@"...DEPARTAMENTOS...");
                                        m.VerDepartamentos(departamentos);
                                        Console.WriteLine("digite el numero del departamento que desea eliminar");
                                        int dptoEliminar = int.Parse(Console.ReadLine());
                                        m.EliminarDepartamento(departamentos, dptoEliminar);

                                        break;

                                    case 3:

                                        Console.WriteLine(@"...DEPARTAMENTOS...");
                                        m.VerDepartamentos(departamentos);

                                        break;

                                    case 4:
                                        opcT = 0;
                                        break;
                                }
                                
                                }
                            else
                            {
                                Console.WriteLine(opc2+" No es un numero valido");
                            }

                            break;
                        }
                        while (opc == 2)
                        {

                            Console.WriteLine(@"...CIUDADES...
                     1. Agregar una ciudad
                     2. Eliminar una Ciudad
                     3. Ver todos las ciudades
                     4. Volver al menu principal");

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
                                    m.AgregarCiudad(ciudades, nombre, extension, poblacion);
                                    break;

                                case 2:
                                    Console.WriteLine(@"...CIUDADES...");
                                    m.Verciudades(ciudades);
                                    Console.WriteLine("digite el numero de la ciudad que desea eliminar");
                                    int ciudadEliminar = int.Parse(Console.ReadLine());
                                    m.EliminarCiudad(ciudades, ciudadEliminar);
                                    break;

                                case 3:
                                    Console.WriteLine(@"...CIUDADES...");
                                    m.Verciudades(ciudades);
                                    break;
                                case 4:
                                    opcT = 0;
                                    break;


                            }
                            break;
                        }//cierre segundo while

                        while (opc == 3)
                        {


                            Console.WriteLine(@"...Barrios...
                     1. Agregar un Barrio
                     2. Eliminar un Barrio
                     3. Ver todos los Barrios
                     4. Volver al menu principal");

                            int opc4 = int.Parse(Console.ReadLine());


                            switch (opc4)
                            {
                                case 1:
                                    Console.WriteLine(@"...Barrios...");
                                    Console.WriteLine("Ingrese nombre del Barrio");
                                    String nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese localidad a la que pertenece");
                                    String localidad = Console.ReadLine();
                                    Console.WriteLine("Ingrese numero de habitantes");
                                    int poblacion = int.Parse(Console.ReadLine());
                                    m.AgregarBarrio(barrios, nombre, localidad, poblacion);
                                    break;

                                case 2:
                                    Console.WriteLine(@"...Barrios...");
                                    m.VerBarrios(barrios);
                                    Console.WriteLine("digite el numero del barrio que desea eliminar");
                                    int barrioEliminar = int.Parse(Console.ReadLine());
                                    m.EliminarBarrio(barrios, barrioEliminar);
                                    break;
                                case 3:
                                    Console.WriteLine(@"...Barrios...");
                                    m.VerBarrios(barrios);
                                    break;
                                case 4:
                                    opcT = 1;
                                    break;
                            }
                            break;
                        }


                        while (opc == 4)
                        {


                            Console.WriteLine(@"...Personas...
                     1. Agregar una persona
                     2. Eliminar una persona
                     3. Ver todos las personas
                     4. Volver al menu principal");

                            int opc5 = int.Parse(Console.ReadLine());


                            switch (opc5)
                            {
                                case 1:
                                    Console.WriteLine(@"...Barrios...");
                                    Console.WriteLine("Ingrese nombre del Barrio");
                                    String nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese localidad a la que pertenece");
                                    String localidad = Console.ReadLine();
                                    Console.WriteLine("Ingrese numero de habitantes");
                                    int poblacion = int.Parse(Console.ReadLine());
                                    m.AgregarBarrio(barrios, nombre, localidad, poblacion);
                                    break;

                                case 2:
                                    Console.WriteLine(@"...Barrios...");
                                    m.VerBarrios(barrios);
                                    Console.WriteLine("digite el numero del barrio que desea eliminar");
                                    int barrioEliminar = int.Parse(Console.ReadLine());
                                    m.EliminarBarrio(barrios, barrioEliminar);
                                    break;
                                case 3:
                                    Console.WriteLine(@"...Barrios...");
                                    m.VerBarrios(barrios);
                                    break;
                                case 4:
                                    opcT = 1;
                                    break;
                            }
                            break;
                        }
                    
                }//cierre de tercer while

                //Console.ReadKey();
            }

        }
       
    }
}



