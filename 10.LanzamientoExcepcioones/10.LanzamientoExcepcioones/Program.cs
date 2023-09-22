using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.LanzamientoExcepcioones
{
    public class Program
    {
        // Podemos forzar a un programa a que lance una excepción con el fin de obligar a otros programadores a que capturen esa excepción 
        // en la implementación de un método
        public static void Main(string[] args)
        {
            Console.WriteLine("Numero mes");
            int mes = int.Parse(Console.ReadLine());
            try
            {
               
                Console.WriteLine(nombreDelMes(mes));
            }catch(ArgumentOutOfRangeException ae)
            {
                Console.WriteLine(ae.Message);
            }
            // este finally se ejecutara aunque el try catch entre en cualqueira de sus dos estados este finally es ideal para
            // usarlao en el cierre de conexiones a bases de datos y cierre de streams para lectura de ficheros
            finally { 
                Console.WriteLine("Ejecucion de finally");
            }
            
        }
        public static string nombreDelMes(int mes)
        {
            switch(mes)
            {
                case 1:
                    return "Enero";
                    break;
                case 2:
                    return "Febrero";
                    break;
                case 3:
                   return "Marzo";
                    break;
                case 4:
                    return "Abril";
                    break;
                case 5:
                    return "Mayo";
                    break;
                case 6:
                   return "Junio";
                    break;
                case 7:
                    return "Julio";
                    break;
                case 8:
                   return "Agosto";
                    break;
                case 9:
                    return "Sepriembre";
                    break;
                case 10:
                    return "Octubre";
                    break;
                case 11:
                    return "Noviembre";
                    break;
                case 12:
                    return "Diciembre";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
