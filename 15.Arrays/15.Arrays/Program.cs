using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Arrays
{
    public class Program
    {
      public static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int[] numeros2 = { 15, 20, 32, 18, 80 };

            //arrayo implicito
            // se les dice implicito ya que ahora mismo el compilador no sabe el tipo, esto lo sabra en tiempo de ejecucion en este caso todos seran de tipo string
            var datos = new[] { "Euclides", "27", "32" };

            //array de objetos

            Empleado empleado1 = new("Euclides", 27);
            Empleado empleado2 = new Empleado("Dilan", 18);
            Empleado empleado3 = new Empleado("Lina", 27);
            Empleado[] empleados =  { empleado1, empleado2, empleado3 };

            //array de clases anonimas
            var personas = new[]
            {
                new { nombre = "Euclides", edad = 15 },
                new { nombre = "Lina", edad = 27 },
                new { nombre = "Ana", edad = 20 },

            };

            // recorrer arrays con for
            for(int i = 0; i < empleados.Length; i++) {
               Console.WriteLine($"{empleados[i].getNombre()}, {empleados[i].getEdad()}");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine($"{personas[i].nombre}, {personas[i].edad}");
            }

            Console.WriteLine("\n");

            // recorrer array con foreach
            foreach (Empleado empleado in empleados)  Console.WriteLine($"{empleado.getNombre()}, {empleado.getEdad()}");
            //ecorrer array de clase anonima con foreach
            Console.WriteLine("\n");
            foreach (var persona in personas) Console.WriteLine($"{persona.nombre}, {persona.edad}");

        }

    }

    public class Empleado {

        private String nombre;
        private int edad;
        public Empleado (String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public int getEdad()
        {
            return this.edad;
        }
    }
}
