using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public sealed class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Year { get; set; }

        public Car ShallowCopy()
        {
            return (Car)this.MemberwiseClone();
        }

        public Car DeepCopy()
        {
            return new Car
            {
                Year = string.Copy(this.Year),
                Model = string.Copy(this.Model),
                Brand = string.Copy(this.Brand)
            };
        }
    }
}
