using System;

namespace AbstractFactory.LandVehicles
{
    class Scooter : ILandVehicle
    {
        public void Getcargo()
        {
            Console.WriteLine("Encomenda na mochila!");
        }

        public void StartRoute()
        {
            Getcargo();
            Console.WriteLine("Iniciando entraga com patinete...");
        }
    }
}
