using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Herencia
{
    public class Program
    {
        public static void Main(string[] args) {
            Caballo caballo1 = new Caballo("Caballo1");
            Humano humano1 = new Humano("Euclides");
            Gorila gorila1 = new Gorila("Gorila1");

            // aplicando polimorfismo este principio hace que podamos instanciar un objeto de la superclase con cualquiera de sus clases derivadas
            // esto me permitira acceder unicamente a los metodos y propiedades de la clase padre.
            Mamifero animal1 = new Caballo("caballo 2");
            Mamifero animal2 = new Gorila("Gorila 2");
            // aplico el principio de sustitucion que es asignarle el animal2 a animal1, aunque son instanciados con clases diferentes ambos son de tipo mamifero
            animal1 = animal2;

            animal1.respirar();
            animal1.getNombre();

            caballo1.respirar();
            caballo1.alimentarse();
            caballo1.galopar();
            caballo1.getNombre();
        }
    }

    public class Mamifero
    {
        private String nombreServivo;

        //constructor
        public Mamifero(String nombre) {
            this.nombreServivo = nombre;
        }   
        public void respirar() {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void alimentarse() {
            Console.WriteLine("Soy capaz de alimentarme");
        }

        public void getNombre() {
            Console.WriteLine("Nombre animal: " + this.nombreServivo);
        }

        public virtual void pensar() { // la palabra virtual indica que este metodo se podra sobreescribir
            Console.WriteLine("Pensamiento basico instintivo");
        }

    }

    public class Caballo : Mamifero {

        // desde el constructor de la clase derivada estamos llamando al constructor de la clase padre para madarle el parametro solicitado
        public Caballo(String nombreCaballo):base(nombreCaballo) { 
        
        }
        public void galopar() {
            Console.WriteLine("Soy capaz de galopar");
        }    
    }


    public class Humano : Mamifero
    {
        public Humano(String nombreHumano) : base(nombreHumano) { 
        
        }


        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }
    public class Gorila : Mamifero
    {
        public Gorila(String nombreGorila) : base(nombreGorila) { }

        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }

    // Notas:
    // Herencia el constructor de la clase derivada siempre llama al constructor de la super clase
    // lo que hacen es decirle a los constructores de la superclase que inicie los objetos

}
