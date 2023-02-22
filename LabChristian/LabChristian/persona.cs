using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabChristian
{
    internal class persona
    {
        abstract class Persona
        {
            public abstract void Nombres();

        }
        class PersonaDatos
        {
            private string Nombre;

            private string Apellido;

            private int Edad;

            private string Departamento;

            private string Municipio;

            public string Nombre1 { get => Nombre; set => Nombre = value; }
            public string Apellido1 { get => Apellido; set => Apellido = value; }
            public int Edad1 { get => Edad; set => Edad = value; }
            public string Departamento1 { get => Departamento; set => Departamento = value; }
            public string Municipio1 { get => Municipio; set => Municipio = value; }


            public void Datos(string _nombre, string _apellido, int _edad,string _departamento,string municipio)
            {
                this.Nombre = _nombre;
                this.Apellido = _apellido;
                this.Edad = _edad;
                this.Departamento = _departamento;
                this.Municipio = municipio; 
                
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("--------   Ingrese  Sus Datos   ----- \n");
                Console.WriteLine("Ingrese su Nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su Apellido:");
                Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese su edad:");
                Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese de que departamento es:");
                Departamento = Console.ReadLine();
                Console.WriteLine("Ingrese de que municipio es: ");
                Console.ReadLine();
                Console.WriteLine("-------------------------------------");
            }

            public void departamentos ()
            {
                Console.WriteLine("Chalatenango");
                Console.WriteLine("San Salvador");
                Console.WriteLine("Santa Ana");
                Console.WriteLine("Usulutan");
                Console.WriteLine("Morazan");
                Console.WriteLine("Ahuachapan");
                Console.WriteLine("La Paz");
                Console.WriteLine("La union");
                Console.WriteLine("San Vicente");
                Console.WriteLine("Morazan");
                Console.WriteLine("Sonsonate");
                Console.WriteLine("Cabañas");
                Console.WriteLine("San miguel");
                Console.WriteLine("La Libertad");
            }

            public string Mostrar()
            {
                Console.WriteLine("-------------------------------------");
                return " \n Nombre: " + Nombre + " \n Apellido: " + Apellido + "\n Edad: " + Edad + "\n Departamento: " + Departamento + "\n Municipio: " + Municipio;
               

            }


        }

    }
    
}