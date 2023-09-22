using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Constructores
{
    public class Program
    {
        public static void Main(string[] args) { 
        
            Coche coche1 = new Coche();
            Coche coche2 = new Coche();


        }
    }



    // clase 
    public class Coche
    {

        //constructor = metodo utilizado para inicializar o modificar los miembros de la clase
        public Coche() {
            this.ruedas = 4;
            this.largo = 5;
            this.ancho = 2;
        }
        //sobrecarga del constructor
        public Coche(int largo, int ancho)
        {
            this.largo=largo;
            this.ancho=ancho;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;

        public int getRuedas()
        {
            return this.ruedas;
        }
    }
}
