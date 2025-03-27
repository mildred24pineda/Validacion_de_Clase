using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace p1bpoo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        private int CargaBateria; 

        public CarroElectrico(int anio, string color, string modelo)
            : base(anio, color, modelo)
        {
            CargaBateria = 50;
        }

        public void CargarBateria()
        {
            if (CargaBateria >= 100)
            {
                Console.WriteLine("¡La batería ya está llena!");
                return;
            }
            CargaBateria = 100; 
            Console.WriteLine("Batería cargada al 100%");
        }

        public int NivelBateria() => CargaBateria; 

        public override void Acelerar(int cuanto)
        {
            if (CargaBateria <= 0)
            {
                Console.WriteLine("¡Batería agotada! Use CargarBateria()");
                return;
            }

            base.Acelerar(cuanto); 
            CargaBateria -= 10; 
            Console.WriteLine($"Batería restante: {CargaBateria}%");
        }
    }
}


