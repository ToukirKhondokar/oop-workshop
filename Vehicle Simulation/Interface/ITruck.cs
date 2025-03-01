using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Simulation.Interface
{
    public interface ITruck:IVehicle
    {
    double FuelQuantity { get; }
    double FuelConsumption { get; }
    const double AirConditionerExtraConsumption = 1.6;
    const double RefuelEfficiency = 0.95;
    }
}