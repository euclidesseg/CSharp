using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CondicionalSwitch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Elige un dia de la semana");
            string dia = Console.ReadLine();

            switch (dia.ToLower())
            {
                case "lunes":
                    Console.WriteLine("Has escogido el día 1");
                    break;
                case "martes":
                    Console.WriteLine("Has escogido el dia 2");
                    break;
                case "miercoles":
                    Console.WriteLine("Has escogido el dia 3");
                    break;
                case "jueves":
                    Console.WriteLine("Has escogido el dia 4");
                    break;
                case "viernes":
                    Console.WriteLine("Has escogido el dia 5");
                    break;
                case "sabaso":
                    Console.WriteLine("Has escogido el dia 6");
                    break;
                case "domingo":
                    Console.WriteLine("Has escogido el dia 7");
                    break;
                default:
                    Console.WriteLine("No existe este dia verifique que si lo ha ingresado correctamente");
                    break;  
            }
        }
    }
}
