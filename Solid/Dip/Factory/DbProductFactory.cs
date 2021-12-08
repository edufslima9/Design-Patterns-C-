using Dip.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Factory
{
    class DbProductFactory
    {

        public static DbProduct Create()
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLServerProduct();
            }
            else
            {
                return new MongoDBProduct();
            }
        }

    }
}
