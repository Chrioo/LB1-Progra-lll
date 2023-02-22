using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabChristian
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            string id;
            Departamentos departamento = new Departamentos();


            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("----------  BIENVEDIDO/A  ----------");
                Console.WriteLine("------------------------ Por favor eliga su departamento-------------------------");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("\n 1 - Chalatenango");
                Console.WriteLine("\n 2 - San Salvador");
                Console.WriteLine("\n 3 - Morazan");
                Console.WriteLine("\n 4 - San vicente");
                Console.WriteLine("\n 5 - La libertad");
                Console.WriteLine("\n 6 - la union");
                Console.WriteLine("\n 7 - Salir");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("\nIngrese el numero de su consulta");
                id = Console.ReadLine();
                switch (id)
                {
                    case "1":
                        Console.WriteLine("\n 1 - Chalatenango");
                        Console.WriteLine("\n 2 - Arcatao");
                        Console.WriteLine("\n 3 - Azacualpa");
                        Console.WriteLine("\n 4 - El paraiso");
                        Console.WriteLine("\n 5 - conception quetzaltepeque");
                        Console.WriteLine("\n 6 - Citalá");
                        Console.WriteLine("\n 7 - Salir");
                        Console.WriteLine("\nIngrese el numero de su consulta");
                        id = Console.ReadLine();
                        switch (id)
                        {
                            case "1":
                                departamento.Date();
                                break;

                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                            case "6":
                                break;
                           
                        }
                        Console.ReadLine();
                        break;
                    case "2":
                        do
                        {
                            Console.WriteLine("\n 1 - San Salvador.");
                            Console.WriteLine("\n 2 - Antiguo Cuscatlán.");
                            Console.WriteLine("\n 3 - Santa Tecla.");
                            Console.WriteLine("\n 4 - Apopa.");
                            Console.WriteLine("\n 5 - Ayutuxtepeque.");
                            Console.WriteLine("\n 6 - Cuscatancingo.");
                            Console.WriteLine("\n 7 - Salir");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    break;

                                case "2":
                                    break;
                                case "3":
                                    break;
                                case "4":
                                    break;
                                case "5":
                                    break;
                                case "6":
                                    break;
                                
                            }

                        }
                        while (id != "5");
                        break;
                    case "3":
                        Console.WriteLine("\n 1 - San Fernando");
                        Console.WriteLine("\n 2 - Cacaopera");
                        Console.WriteLine("\n 3 - Chilanga");
                        Console.WriteLine("\n 4 - Corinto");
                        Console.WriteLine("\n 5 - El Rosario");
                        Console.WriteLine("\n 6 - Gualococti");
                        Console.WriteLine("\n 7 - Salir");
                        Console.WriteLine("\nIngrese el Numero de su Consulta");
                        id = Console.ReadLine();
                        switch (id)
                        {
                            case "1":
                                break;

                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                            case "6":
                                break;
                          
                        }
                        break;
                    case "4":
                        Console.WriteLine("\n 1 - San Vicente");
                        Console.WriteLine("\n 2 - Apastepeque");
                        Console.WriteLine("\n 3 - Guadalupe");
                        Console.WriteLine("\n 4 - Tecoluca");
                        Console.WriteLine("\n 5 - Verapaz");
                        Console.WriteLine("\n 6 - Tepetitán");
                        Console.WriteLine("\n 7 - Salir");
                        Console.WriteLine("\nIngrese el Numero de su Consulta");
                        id = Console.ReadLine();
                        switch (id)
                        {
                            case "1":
                                break;

                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                            case "6":
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("\n 1 - Antiguo Cuscatlán");
                        Console.WriteLine("\n 2 - Chiltiupán");
                        Console.WriteLine("\n 3 - Ciudad Arce");
                        Console.WriteLine("\n 4 - Comasagua");
                        Console.WriteLine("\n 5 - Nuevo Cuscatlán");
                        Console.WriteLine("\n 6 - Talnique");
                        Console.WriteLine("\n 7 - Salir");
                        Console.WriteLine("\nIngrese el Numero de su Consulta");
                        id = Console.ReadLine();
                        switch (id)
                        {
                            case "1":
                                break;

                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                            case "6":
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("\n1 - Anamorós.");
                        Console.WriteLine("\n2 - Bolívar.");
                        Console.WriteLine("\n3 - Concepción de Oriente.");
                        Console.WriteLine("\n4 - Conchagua.");
                        Console.WriteLine("\n5 - El Carmen.");
                        Console.WriteLine("\n6 - El Sauce.");
                        Console.WriteLine("\n7 - Salir");
                        Console.WriteLine("\nIngrese el Numero de su Consulta");
                        id = Console.ReadLine();
                        switch (id)
                        {
                            case "1":
                                break;

                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                            case "6":
                                break;
                        }
                        break;

                }

            }
            while (id != "6");

        }

        class Departamentos
        {
            public void ltDepartamentos()
            {
                string[] departamento = new string[6];
                departamento[0] = "Chalatenango";
                departamento[1] = "San Salvador";
                departamento[2] = "Morazan";
                departamento[3] = "San Vicente";
                departamento[4] = "La libertad";
                departamento[5] = "La Union";

            }

            public void Date()
            {

                List<string> Nombre = new List<string>();
                Nombre.Add("Ingrese su Nombre");
                List<string> Apellido = new List<string>();
                Console.WriteLine("Ingrese su Nombre:");
               Apellido.Add("Console.ReadLine()");
                List<string> Edad = new List<string>();
                Console.WriteLine("Ingrese Su edad:");
                Edad.Add(Console.ReadLine());
                List<string> Sexo = new List<string>();
                Console.WriteLine("Ingrese Su Sexo:");
                Sexo.Add(Console.ReadLine());
                Console.WriteLine("  Nombres: " + Nombre + " Apellido: " + Apellido + "  Sexo: " + Sexo + "  Edad: " +Edad);
            }

        }
    }
}