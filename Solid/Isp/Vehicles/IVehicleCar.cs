﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicles
{
    interface IVehicleCar : IVehicles
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
    }
}
