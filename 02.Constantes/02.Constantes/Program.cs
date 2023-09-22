using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Constantes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Las constantes van con mayusculas
            const double PI = 3.1416;
            Console.WriteLine("Indroduce la medida del radio");
            double radio = double.Parse(Console.ReadLine());

            double area = PI * Math.Pow(radio, 2);

            Console.WriteLine(area);
        }
    }
}
