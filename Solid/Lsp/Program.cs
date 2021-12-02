using Lsp.Payments;
using System;

namespace Lsp
{
    class Program
    {
        static void Main(string[] args)
        {
            NubankRewards card = new NubankRewards();
            card.Validate();
            card.CollectPayment();

            Console.ReadLine();
        }
    }
}
