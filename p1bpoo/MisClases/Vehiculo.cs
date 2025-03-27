using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }
        private int velocidad = 0;
        private int estado = 0; 
        public Chofer PilotoAsignado { get; private set; }

        protected virtual int VelocidadMaxima { get; } = 120;
        protected virtual int CapacidadTanque { get; } = 50;
        protected virtual int ConsumoCombustible { get; } = 1;

        public Vehiculo(int anio, string color, string modelo)
        {
            if (anio > DateTime.Now.Year)
                throw new ArgumentException("ERROR: El año no puede ser futuro.");

            Color = color;
            Modelo = modelo;
            Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Year}");
            Console.WriteLine($"Velocidad actual: {velocidad} km/h");
            Console.WriteLine($"Velocidad máxima: {VelocidadMaxima} km/h");
            Console.WriteLine($"Estado: {(estado == 0 ? "Apagado" : estado == 1 ? "Encendido" : "En movimiento")}");
            Console.WriteLine($"Piloto: {(PilotoAsignado != null ? PilotoAsignado.Nombre : "Ninguno")}");
        }

        public virtual void Acelerar(int cuanto)
        {
            if (cuanto < 0)
                throw new ArgumentException("ERROR: La aceleración no puede ser negativa.");

            if (velocidad + cuanto > VelocidadMaxima)
            {
                Console.WriteLine($"¡Alerta! No se puede superar la velocidad máxima de {VelocidadMaxima} km/h.");
                velocidad = VelocidadMaxima;
            }
            else
            {
                velocidad += cuanto;
            }

            estado = velocidad > 0 ? 2 : 1;
            Console.WriteLine($"Velocidad actual: {velocidad} km/h");
        }

        public void Frenar(int cuanto)
        {
            if (cuanto < 0)
                throw new ArgumentException("ERROR: El frenado no puede ser negativo.");

            velocidad = Math.Max(0, velocidad - cuanto);

            if (velocidad == 0)
            {
                estado = 1; 
            }

            Console.WriteLine($"Velocidad actual: {velocidad} km/h");
        }

        public void Apagar()
        {
            if (velocidad > 0)
            {
                Console.WriteLine("No se puede apagar el vehículo en movimiento.");
                return;
            }

            estado = 0;
            Console.WriteLine("Vehículo apagado correctamente.");
        }

        public void AsignarPiloto(Chofer piloto)
        {
            PilotoAsignado = piloto;
            Console.WriteLine($"Piloto {piloto.Nombre} asignado al vehículo.");
        }
    }
}