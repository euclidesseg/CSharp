using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Interfaces
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            Console.WriteLine(operaciones.sumar(24, 7));
            Console.WriteLine(operaciones.restar(24, 7));
            Console.WriteLine(operaciones.multiplicar(24, 7));
            Console.WriteLine(operaciones.dividir(24, 7));

        }
    }


    public class Operaciones : IOperaciones
    {
        public double dividir(int nume1, int num2)
        {
           return nume1 / num2;
        }

        public double multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public double restar(int nume1, int num2)
        {
            return nume1 - num2;
        }

        public double sumar(int num1, int num2)
        {
            return num1 + num2;
        }
    }


    // una interface es una especie de contrato que cualquier clase que la implemente debe cumplir para poder usar sus metodos
    // en una interface solo existen declaraciones de metodos es decir, que nunca se van a desaroollar sus metodos y nunca llevaran campos de clase
    interface IOperaciones
    {
        public double sumar(int num1, int num2);
        public double restar(int nume1, int num2);
        public double multiplicar(int nume1, int num2);
        public double dividir(int nume1, int num2);
    }
}
