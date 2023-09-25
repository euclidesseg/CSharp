using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ClaseMath
{
    public class Punto
    {
        private int x, y;
        private static int contadorObjetos = 0;  // ejemplo para campos static
        public Punto() {
            this.x = 0;
            this.y = 0;
            contadorObjetos++;
        }

        public Punto(int x, int y) {
            this.x = x;
            this.y = y;
            contadorObjetos ++;
        }

        public double getDistancia(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.x - otroPunto.y;

            double distanciaEntrePuntos = Math.Sqrt(Math.Pow(xDif, 2) +  Math.Pow(yDif, 2));
            return distanciaEntrePuntos;

        }

        public static int getContadorObjetos() => contadorObjetos;
    }
}