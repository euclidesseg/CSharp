using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ClaseMath
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            realizarTarea();
        }
        public static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);

            double distanciaEntrePuntos = origen.getDistancia(destino);
            Console.WriteLine($"distancia {distanciaEntrePuntos}");
            Console.WriteLine("Objetos instanciados: " + Punto.getContadorObjetos());
        }
    }

    // Variables de clase o static 
    /* Sucede que cuando instanciamos un objeto de una clase cada objeto creara una copia de ese campo o metodo
     * siempre y cuando no sea static los campos de tipo static pertenecen a la clase por lo tanto no pueden ser accedidos
     * ni modificados desde una instancia, estos campos solo pueden ser llamados desde la propia clase ejemplo Math.Pow();
     * entonces cuando modificamos un campo static desde cualquier parte de un codigo ese dato al no ser una copia se modificara 
     * para todas sus llamadas */
}
