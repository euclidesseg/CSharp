using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.EjercicioPractico
{
    public class Vehiculo
    {
        private int kH;
        public Vehiculo(int velocidad) {
            this.kH=  velocidad;
        }

        public void Arrancar() {
            Console.WriteLine("\n El motor ha arrancado");
        }

        public void pararMotor()
        {
            Console.WriteLine("Se ha detenido el motor");
        }
        public virtual void conducir() { }
    }
}
