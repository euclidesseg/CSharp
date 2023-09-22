using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.DoWhile
{
    // Cuando trabjamos con doWhile damos por hecho que al menos una vez se va a ejecutar el codigo en su interior
    // esto ya que la condicion ira luego del codigo a ejecutar
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero = 1;
            do
            {
                Console.WriteLine(numero);
                numero ++;
            } while (numero <= 10);
        }
    }
}