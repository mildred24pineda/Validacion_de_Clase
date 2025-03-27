using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Tractor : Vehiculo
    {
       
        public bool TieneArado { get; private set; }
        public int NumeroMarchas { get; }

        
        public Tractor(int anio, string color, string modelo, bool tieneArado, int numeroMarchas)
            : base(anio, color, modelo)
        {
            TieneArado = tieneArado;
            NumeroMarchas = numeroMarchas;
        }

      
        public void Arar()
        {
            if (!TieneArado)
            {
                Console.WriteLine("¡Este tractor no tiene arado instalado!");
                return;
            }
            Console.WriteLine("Arando la tierra...");
        }

        public void CambiarMarcha(int marcha)
        {
            if (marcha < 1 || marcha > NumeroMarchas)
            {
                Console.WriteLine($"¡Marcha inválida! Este tractor tiene {NumeroMarchas} marchas.");
                return;
            }
            Console.WriteLine($"Cambiando a marcha {marcha}...");
        }

       
        protected override int VelocidadMaxima => 40;  
        protected override int CapacidadTanque => 120; 
        protected override int ConsumoCombustible => 6; 
    }
}
