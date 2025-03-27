

using System;
using p1bpoo.MisClases;

class Program
{
    static void Main()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("            CLASE VEHÍCULO          ");
        Console.WriteLine("====================================");
        Vehiculo vehiculo1 = new Vehiculo(2023, "Rojo", "Toyota Corolla");
        vehiculo1.InformacionVehiculo();
        vehiculo1.Acelerar(60);
        vehiculo1.Frenar(20);
        Console.WriteLine("\n");

        Console.WriteLine("====================================");
        Console.WriteLine("          CARRO ELÉCTRICO           ");
        Console.WriteLine("====================================");
        CarroElectrico tesla = new CarroElectrico(2023, "Blanco", "Tesla Model 3");
        tesla.InformacionVehiculo();
        tesla.Acelerar(40);
        tesla.CargarBateria();
        Console.WriteLine("\n");

        Console.WriteLine("====================================");
        Console.WriteLine("             CLASE MOTO             ");
        Console.WriteLine("====================================");
        Moto moto = new Moto(2023, "Negro", "Yamaha R1", true);
        moto.InformacionVehiculo();
        moto.Acelerar(80);
        moto.HacerCaballito();
        Console.WriteLine("\n");

        Console.WriteLine("====================================");
        Console.WriteLine("            CLASE PICKUP            ");
        Console.WriteLine("====================================");
        Pickup ford = new Pickup(2023, "Azul", "Ford F-150", 1500);
        ford.InformacionVehiculo();
        ford.Cargar(800);
        ford.AbrirCaja();
        Console.WriteLine("\n");

        Console.WriteLine("====================================");
        Console.WriteLine("            CLASE TRACTOR           ");
        Console.WriteLine("====================================");
        Tractor johnDeere = new Tractor(2023, "Verde", "John Deere", true, 6);
        johnDeere.InformacionVehiculo();
        johnDeere.Arar();
        johnDeere.CambiarMarcha(3);
        Console.WriteLine("\n");

        Console.WriteLine("====================================");
        Console.WriteLine("            CLASE CHOFER            ");
        Console.WriteLine("====================================");
        Chofer chofer = new Chofer("Carlos Méndez", "LIC-2024");
        chofer.AsignarVehiculo(ford);
        chofer.Conducir(50);
        chofer.MostrarInfo();
    }
}

