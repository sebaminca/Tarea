using System;

namespace Clase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Sebastian "; 
            string apellido = "Minca ";
            int edad = 32 ; 
            string fechaactual = "12 10 2020" ;
            string fechanacimiento = "13 07 1988" ;

            Console.WriteLine("Hola soy");
            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            Console.WriteLine(edad);
            Console.WriteLine(fechaactual);
            Console.WriteLine(fechanacimiento);

            Console.WriteLine("el resultado de 2 + 3 es " + (2 + 3));

            Console.WriteLine("el resultado de 2 - 3 es " + (2 - 3));
            
            Console.WriteLine("el resultado de 2 multiplicado por 3, dividido 2 es " + ((2 * 3) / 2));

            Console.WriteLine("secuencia de resultados = 2 + 3, = 3 - 1, = 2 * 5, " + (2 + 1) + (3 - 1) + (2 * 5));

        }
    }
}
