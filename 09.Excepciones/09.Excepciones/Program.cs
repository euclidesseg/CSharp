using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Excepciones
{
    // Las excepciones son errores que suceden en tiempo de ejecución y que el programador no ha podido controlar
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(0,50);
            int miNumero;
            int intentos = 0;

            Console.WriteLine("Introduce un numero entre 0 y 50");
            do
            {
                intentos++;
                try
                {
                    miNumero = int.Parse(Console.ReadLine());

                }catch(FormatException fe) // Excepcion de tipo formato 
                {
                    Console.WriteLine("Ha ocurrido un error ", fe.Message);
                    miNumero = 0;
                }
                // Encadenamiento de excepciones 
                catch(OverflowException oe)
                {
                    Console.WriteLine(oe.Message);
                    miNumero = 0;
                }
                // filtrado de excepciones, esta filtrara solo las que sean diferente de FormatExcepcion
                catch (Exception e)when(e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("Error", e.Message);
                    miNumero = 0;
                }
                // excepcion generica ya que las demas dependen de esta excepcion, no podemos agregar otras excepciones luego de esta
                catch (Exception e)
                {
                    Console.WriteLine("Error", e.Message);
                    miNumero = 0;
                }
                if (miNumero < aleatorio) Console.WriteLine("El numero es mayor");
                if (miNumero > aleatorio) Console.WriteLine("El numero es menor");
            } while (aleatorio != miNumero);
            Console.WriteLine("Has intentado " + intentos + " veces para conseguirlo");
        }
    }
}
