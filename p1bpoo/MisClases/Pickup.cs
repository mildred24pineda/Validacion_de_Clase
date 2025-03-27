using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    
        internal class Pickup : Vehiculo
        {
            
            public double CapacidadCargaKg { get; } 
            public bool TieneCajaAbierta { get; private set; }

           
            public Pickup(int anio, string color, string modelo, double capacidadCargaKg)
                : base(anio, color, modelo)
            {
                CapacidadCargaKg = capacidadCargaKg;
                TieneCajaAbierta = false;
            }

           
            public void AbrirCaja()
            {
                TieneCajaAbierta = true;
                Console.WriteLine("Caja de pickup abierta.");
            }

            public void CerrarCaja()
            {
                TieneCajaAbierta = false;
                Console.WriteLine("Caja de pickup cerrada.");
            }

            public void Cargar(double pesoKg)
            {
                if (pesoKg > CapacidadCargaKg)
                {
                    Console.WriteLine($"¡Advertencia! No se pueden cargar {pesoKg} kg (Máximo: {CapacidadCargaKg} kg).");
                    return;
                }
                Console.WriteLine($"Cargados {pesoKg} kg en la pickup.");
            }

            
            protected override int VelocidadMaxima => 100; 
            protected override int CapacidadTanque => 80;  
            protected override int ConsumoCombustible => 4; 
        }
    
}
