using System;

namespace AbstractFactory.Aircrafts
{
    class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos a 25km, ventos ok!");
        }

        public void Getcargo()
        {
            Console.WriteLine("Passageiros à bordo, voô autorizado.");
        }

        public void StartRoute()
        {
            CheckWind();
            Getcargo();
            Console.WriteLine("Iniciando decolagem...");
        }
    }
}
