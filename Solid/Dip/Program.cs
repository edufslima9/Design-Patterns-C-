using Dip.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProccess payment = new PaymentProccess();
            payment.Pay("ABC123");

            Console.ReadLine();
        }
    }
}
