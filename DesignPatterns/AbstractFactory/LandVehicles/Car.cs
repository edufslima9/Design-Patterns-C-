using System;

namespace AbstractFactory.LandVehicles
{
    class Car : ILandVehicle
    {
        public void Getcargo()
        {
            Console.WriteLine("Pegamos os passageiros, estamos prontos!");
        }

        public void StartRoute()
        {
            Getcargo();
            Console.WriteLine("Iniciando o trajeto.");
        }
    }
}
