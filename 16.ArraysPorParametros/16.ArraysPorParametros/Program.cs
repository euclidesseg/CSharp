using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ArraysPorParametros
{
    public class Program
    {
        public static void Main(string[] args) {
            int[] numeros = new int[5] { 7, 3, 4, 9, 15 };
            procesarDatos(numeros);
        }

        static void procesarDatos(int[] datos) {
            foreach (int dato in datos){
                Console.WriteLine(dato);
            }
        }
    }
}
