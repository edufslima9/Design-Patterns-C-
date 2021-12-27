using Singleton.NonThreadSafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.NonThreadSafe.Singleton s1 = Singleton.NonThreadSafe.Singleton.GetInstance();
            Singleton.NonThreadSafe.Singleton s2 = Singleton.NonThreadSafe.Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            // The client code.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "Se você vir o mesmo valor, o singleton foi reutilizado (yay!)",
                "Se você vir valores diferentes, então 2 singletons foram criados (booo!!)",
                "RESULT:"
            );

            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();

            Console.ReadLine();
        }

        public static void TestSingleton(string value)
        {
            Singleton.ThreadSafe.Singleton singleton = Singleton.ThreadSafe.Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
