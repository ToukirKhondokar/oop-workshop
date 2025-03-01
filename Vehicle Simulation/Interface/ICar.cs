using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Simulation.Interface
{
    public interface ICar:IVehicle
    {
        double FuelQuantity{ get; }
        double FuelConsumption { get; }
        const double AirConditionerExtraConsumption = 0.9;
    }
}