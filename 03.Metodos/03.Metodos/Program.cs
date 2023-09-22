using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.Metodos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            mensajeEnPantalla();
            sumaNumeros(5, 12);
            Console.WriteLine("La suma devuelta es: " + suma(25, 25));
        }

        // void no me va a retornar nada
        public static void mensajeEnPantalla()
        {
            Console.WriteLine("I am learning C# with vs");
        }

        // metodos con parametros
        public static void sumaNumeros(int numero1, int numero2)
        {
            Console.WriteLine("La suma de los numeros es: " + (numero1 + numero2));
        }

        // metodos con retorno de valores
        public static int suma(int numero1, int numero2) =>  numero1 + numero2; 
        
    }
}
