using Prototype.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car { Year = "2001", Brand = "Fiat", Model = "Uno" };
            
            var carTwo = carOne;
            var carThree = carOne.ShallowCopy();
            var carFour = carOne.DeepCopy();

            Console.WriteLine($"Car One: {carOne.Model} | {carOne.Brand} | {carOne.Year}");
            Console.WriteLine($"Car Two: {carTwo.Model} | {carTwo.Brand} | {carTwo.Year}");
            Console.WriteLine($"Car Three: {carThree.Model} | {carThree.Brand} | {carThree.Year}");
            Console.WriteLine($"Car Four: {carFour.Model} | {carFour.Brand} | {carFour.Year}");
            Console.WriteLine();

            carTwo.Year = "2015";

            carThree.Model = "Argo";
            carThree.Year = "2021";

            carFour.Brand = "Honda";
            carFour.Model = "Civic";
            carFour.Year = "2021";

            Console.WriteLine($"Car One: {carOne.Model} | {carOne.Brand} | {carOne.Year}");
            Console.WriteLine($"Car Two: {carTwo.Model} | {carTwo.Brand} | {carTwo.Year}");
            Console.WriteLine($"Car Three: {carThree.Model} | {carThree.Brand} | {carThree.Year}");
            Console.WriteLine($"Car Four: {carFour.Model} | {carFour.Brand} | {carFour.Year}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Person p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1977-05-15");
            p1.Name = "Jack Daniels";
            p1.IdInfo = new IdInfo(666);

            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 = p1.ShallowCopy();
            // Make a deep copy of p1 and assign it to p3.
            Person p3 = p1.DeepCopy();

            // Display values of p1, p2 and p3.
            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            // Change the value of p1 properties and display the values of p1,
            // p2 and p3.
            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-26");
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);

            Console.ReadLine();
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:dd/MM/yyyy}",
                p.Name, p.Age, p.BirthDate);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
    }
}
