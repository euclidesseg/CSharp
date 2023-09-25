﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.EjercicioPractico
{
    public class Avion:Vehiculo
    {
        int velocidadMaxima;
        public Avion(int velocidadMaxima) : base(velocidadMaxima) {
            this.velocidadMaxima = velocidadMaxima;
        }
        public override void conducir()
        {
            Console.WriteLine("El avión podra conducir a una velocidad maxima de: "+ velocidadMaxima + "k/h");
        }
    }
}
