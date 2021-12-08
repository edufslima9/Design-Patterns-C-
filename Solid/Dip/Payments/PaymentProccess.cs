using Dip.Factory;
using Dip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Payments
{
    class PaymentProccess
    {

        public void Pay(string id)
        {
            DbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);
            Console.WriteLine(productData);
        }

    }
}
