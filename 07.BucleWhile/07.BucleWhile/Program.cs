using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BucleWhile
{
    public class Program
    {
        //Cuando trabajamos con while nunca sabemos cuantas veces se ejecutara el codigo en su interior incluso no sabemos si se va ejecutar
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            int nPeticiones = 3;
            string password2 = "";
           
            Console.WriteLine("Introduzca la contraseña");
            string password = Console.ReadLine();


            while (password != password2)
            {
                if(nPeticiones >= 1){

                    Console.WriteLine("Confirme nuevamente! intentos restantes: " +(nPeticiones));
                    password2 = Console.ReadLine();
                    if(password == password2)  Console.WriteLine("Password confirmed");

                    nPeticiones--;
                }
                else
                {
                    Console.WriteLine("You have no attempts.");
                    break;
                }
              
            }

            Console.WriteLine("End of Progam");
        }
    }
}
