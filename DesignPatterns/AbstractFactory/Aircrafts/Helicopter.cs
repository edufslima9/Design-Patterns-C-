using System;

namespace AbstractFactory.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando vento, vento sudeste, ventos ok!");
        }

        public void Getcargo()
        {
            Console.WriteLine("Passageiros ok. Ligando as helices.");
        }

        public void StartRoute()
        {
            CheckWind();
            Getcargo();
            Console.WriteLine("Iniciando a decolagem!!!");
        }
    }
}
