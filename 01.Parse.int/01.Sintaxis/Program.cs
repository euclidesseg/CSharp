using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sintaxis
{
    public  class Program
    {
        static void Main(string[] args)
        {
            // conversion implicita entre tipos similares
            double numeroDecimal = 238.6;
            int numeroEntero = (int) numeroDecimal;
            double numeroDecimal2 = (double) numeroEntero;
            Console.WriteLine(numeroEntero);
            Console.WriteLine(numeroDecimal2);

            //conversion entre tipos totalmente diferentes
            string edad = "25";
            int edadNumerica = Convert.ToInt32(edad);
            Console.WriteLine(edad.GetType());
            Console.WriteLine(edadNumerica.GetType());

            Console.WriteLine("Ingresa un numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero ingresado es: " + numero1);
        }
    }
}
