using System;
namespace _05.CondicionalesIF
{
    public class Program
    {
        public static void Main(string[] argas)
        {

            int edad;
            bool licencia;

            Console.WriteLine("Ingresa tu edad");
            edad = Int32.Parse(Console.ReadLine());


            if(edad < 18)
            {
                Console.WriteLine("No puedes conseguir");
            }
            else
            {

                Console.WriteLine("Tiene licencia");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "si")
                {
                    licencia = true;
                }
                else
                {
                    licencia = false;
                }

                if (licencia){
                    Console.WriteLine("Pudes Conducir");
                }else                {
                    Console.WriteLine("No puedes Conducir");
                }
            }
           
        }
    }
}
