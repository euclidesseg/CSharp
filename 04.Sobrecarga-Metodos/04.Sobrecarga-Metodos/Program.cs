using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sobrecarga_Metodos
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(multiplicar(7, 12));
            Console.WriteLine(multiplicar(3, 7, 9));
            Console.WriteLine(multiplicar(3, 7.2));

    }
    // La sobrecarga de metodos es una serie de metodos con el mismo nombre y en la misma clase
    // pero con diferente tipo y lingitud de metodos
    public static int multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        
        public static int multiplicar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 * numero3;
     
        }

        //parametros opcionales
        public static double multiplicar(int numero1, double numero2, int numero3 = 0)
        {
            return (numero1 + numero2 + numero3);
        }
    }


}
