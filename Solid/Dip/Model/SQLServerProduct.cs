using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Model
{
    class SQLServerProduct : DbProduct
    {
        public string GetProductById(string id)
        {
            return $"SQLServer: Exibindo dados do produto {id}.";
        }
    }
}
