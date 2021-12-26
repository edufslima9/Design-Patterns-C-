using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedan();
            Vehicle sedan = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {sedan.VehicleType}");
            Console.WriteLine($"Assentos: {sedan.Seats}");
            Console.WriteLine($"Motor: {sedan.Engine.Power}");
            Console.WriteLine($"Transmissão: {sedan.Transmission}");
            Console.WriteLine($"Airbags: {sedan.AirBags}");
            Console.WriteLine();
            Console.WriteLine();

            director.ConstructTruck();
            Vehicle truck = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {truck.VehicleType}");
            Console.WriteLine($"Assentos: {truck.Seats}");
            Console.WriteLine($"Motor: {truck.Engine.Power}");
            Console.WriteLine($"Transmissão: {truck.Transmission}");
            Console.WriteLine($"Airbags: {truck.AirBags}");
            Console.WriteLine();
            Console.WriteLine();

            director.ConstructSUV();
            Vehicle suv = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {suv.VehicleType}");
            Console.WriteLine($"Assentos: {suv.Seats}");
            Console.WriteLine($"Motor: {suv.Engine.Power}");
            Console.WriteLine($"Transmissão: {suv.Transmission}");
            Console.WriteLine($"Airbags: {suv.AirBags}");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
