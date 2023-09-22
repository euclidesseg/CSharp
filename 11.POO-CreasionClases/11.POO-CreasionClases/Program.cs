using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.POO_CreasionClases
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Circulo circulo1 = new Circulo(); //instanciacion de la clase circulo
            Console.WriteLine(circulo1.calculoArea(10));
        }
    }

    // nueva clase
    public class Circulo
    {
        const double pi = 3.1416;
        private double radio;

        public double calculoArea(int radio)
        {
            return pi * (radio * radio);
        }
    }
}
