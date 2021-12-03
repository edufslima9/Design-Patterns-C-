using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicles
{
    class Motorcycle : IVehicleMotorcycle
    {
        private string color;
        private int year;
        private double engine;

        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;

            Console.WriteLine($"Criando uma moto ano {year}, {engine} cilindradas, da cor {color}.");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores.");
        }
    }
}
