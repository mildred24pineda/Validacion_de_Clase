using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Moto : Vehiculo
    {
        public bool TieneCasco { get; set; }

        public Moto(int anio, string color, string modelo, bool tieneCasco)
            : base(anio, color, modelo)
        {
            TieneCasco = tieneCasco;
        }

        public void HacerCaballito()
        {
            if (VelocidadMaxima > 0)
                Console.WriteLine("¡Realizando caballito!");
            else
                Console.WriteLine("¡La moto debe estar en movimiento!");
        }
    }
}