using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.EjercicioPractico
{
    internal class Program
    {
        public static void Main(string[] args) {
            Avion avion1 = new Avion(600);
            avion1.Arrancar();
            avion1.conducir();
            avion1.pararMotor();

            Coche coche1 = new Coche(160);
            coche1.Arrancar();
            coche1.conducir();
            coche1.pararMotor();
        }
    }
}
