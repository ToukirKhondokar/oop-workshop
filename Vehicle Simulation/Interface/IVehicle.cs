using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Simulation.Interface
{
    public interface IVehicle
    {
         void Drive(int distance);
         void Refuel(int amount);
        double GetFuelQuantity();
    }
}