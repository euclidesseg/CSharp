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
            coche1.setTapiceria("cuero");
            coche1.setClimatizador(true);

            Console.WriteLine(coche1.getInfo());

            // otra instancia

            Console.WriteLine("");
            Coche coche2 = new Coche(5, 3);

            coche2.setTapiceria("tela");
            coche2.setClimatizador(false);

            Console.WriteLine(coche2.getInfo());
        }
    }



    // clase 
    public class Coche
    {

        //constructor = metodo utilizado para inicializar o modificar los miembros de la clase
        public Coche() {
            this.ruedas = 4;
            this.largo = 4;
            this.ancho = 2;
        }
        //sobrecarga del constructor
        public Coche(int largo, int ancho)
        {
            this.ruedas = 4;
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

        public double getLargo()
        {
            return this.largo;
        }

        public double getAncho()
        {
            return this.ancho;
        }

        public bool getClimatizador()
        {
            return this.climatizador;
        }
        public void setClimatizador(bool climatizador)
        {
            this.climatizador = climatizador;
        }

        //tapiceria
        public String getTapiceria()
        {
            return this.tapiceria;
        }
        public void setTapiceria(String tapiceria)
        {
            this.tapiceria = tapiceria;
        }

        public string getInfo()
        {
            return "Info: \n " +
                "Ruedas: " + this.ruedas
                + "\n Largo: " + this.largo + " \n Ancho: " + this.ancho + " \n Cliatizador: " + this.climatizador
                + "\n Tapiceria: " + this.tapiceria; 
        }
    }
}
