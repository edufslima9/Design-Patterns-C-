using System;

namespace AbstractFactory.LandVehicles
{
    class Motorcycle : ILandVehicle
    {
        public void Getcargo()
        {
            Console.WriteLine("Pegamos a encomenda.");
        }

        public void StartRoute()
        {
            Getcargo();
            Console.WriteLine("Iniciando a entrega.");
        }
    }
}
