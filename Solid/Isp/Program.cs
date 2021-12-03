using Isp.Vehicles;
using System;

namespace Isp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Preto", 2021, 4.0, 2, 2);
            Motorcycle motorcycle = new Motorcycle("Vermelho", 2021, 600);

            Console.ReadLine();
        }
    }
}
