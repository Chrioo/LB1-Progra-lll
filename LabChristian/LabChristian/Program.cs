using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabChristian
{
    internal class Program : persona
    {
        static void Main(string[] args)
        {
            persona persona = new persona();
            
            string id;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\n1 -------- Ingrese su Informacion -----------------------");
            Console.WriteLine("\n2 ------------  Salir");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\n  Ingrese el numero de su consulta");
            id = Console.ReadLine();
              switch (id)
              {
                case "1":

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("__________  Departamentos  __________\n");
                    Console.WriteLine("\n1 - Chalatenango ----------------------------\n");
                    Console.WriteLine("\n2 - San Salvador ------------------------------\n");
                    Console.WriteLine("\n3 - San vicente --------------------\n");
                    Console.WriteLine("\n4 - Morazan ---------------------------\n");
                    Console.WriteLine("\n5 - La Libertad -------------------------\n");
                    Console.WriteLine("\n6 - La Union ----------------------------\n");
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("\n7 - Salir");
                    Console.WriteLine("\nIngrese el numero de su consulta");
                    id = Console.ReadLine();
                    
                    switch (id)
                    {






                    }
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

                default:

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La opcion que ha elegido no es correcta");
                    Console.ReadKey();
                    break;

              }

        }
    }

}