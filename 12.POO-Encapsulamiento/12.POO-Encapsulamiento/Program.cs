using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.POO_Encapsulamiento
{
    public class Program
    {
        // Encapsulacion habilidad de agregarle una palabra recervada a las clases campos o metods para que se mantengan en un estado especifico
        // en C# pueden serÑ
        // public    = estos tipos estan visibles desde el propio proyecto y desde otros sin restriccion
        // private   = permite el acceso solo a los miembros de la misma clase y pueden ser leidos y modificados solo atravez de metodos de acceso
        // protected = Accesible solo a los miembros de la misma clase y de las claes hijas de este
        // internal  = El acceso esta disponible desde cualqueir clase del mismo proyecto pero no desde otros proyectos de la misma solucion
        public static void Main(string[] args)
        {
            Conversor cs = new Conversor();

            Console.WriteLine(cs.convertirADolar(25000000));
        }


        // nueva clase
        public class Conversor
        {
            private double dolar = 4100;
            public double convertirADolar(double valor){
                return  valor / dolar;
            }

            public void modificarDolar(double valor)
            {
                if (valor <= 0) this.dolar = 4.100;
                
                this.dolar = valor;
            }
        }
    }
}
