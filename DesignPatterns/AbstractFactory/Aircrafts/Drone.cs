using System;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Sem ventos, ventos ok!");
        }

        public void Getcargo()
        {
            Console.WriteLine("Encomenda acoplada!");
        }

        public void StartRoute()
        {
            CheckWind();
            Getcargo();
            Console.WriteLine("Iniciando decolagem e trajeto");
        }
    }
}
