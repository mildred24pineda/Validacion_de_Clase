using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace p1bpoo.MisClases
{
    internal class Chofer
    {
        public string Nombre { get; set; }
        public string Licencia { get; set; }
        public Vehiculo VehiculoAsignado { get; private set; }

        public Chofer(string nombre, string licencia)
        {
            Nombre = nombre;
            Licencia = licencia;
        }

        public void AsignarVehiculo(Vehiculo vehiculo)
        {
            VehiculoAsignado = vehiculo;
            Console.WriteLine($"{Nombre} ahora conduce un {vehiculo.Modelo}");
        }


        public void Conducir(int aceleracion)
        {
            if (VehiculoAsignado == null)
            {
                Console.WriteLine("¡Error! No hay vehículo asignado.");
                return;
            }
            Console.WriteLine($"{Nombre} está conduciendo el {VehiculoAsignado.Modelo}...");
            VehiculoAsignado.Acelerar(aceleracion);
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Chofer: {Nombre} | Licencia: {Licencia}");
            if (VehiculoAsignado != null)
                Console.WriteLine($"Vehículo asignado: {VehiculoAsignado.Modelo}");
            else
                Console.WriteLine("Sin vehículo asignado.");
        }
    }
}