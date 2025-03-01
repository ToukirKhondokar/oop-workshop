using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Simulation.Interface;

namespace Vehicle_Simulation.Entites
{
    public class Car : ICar
    {
        private double _fuelQuantity;
        public double FuelQuantity { get => _fuelQuantity; set => _fuelQuantity = value; }

        private double _fuelConsumption;
        public double FuelConsumption { get => _fuelConsumption; set => _fuelConsumption = value; }

        public Car(double fuelQuantity, double fuelConsumption)
        {
            _fuelConsumption = fuelConsumption + ICar.AirConditionerExtraConsumption;
            _fuelQuantity = fuelQuantity;
        }

        public void Drive(int distance)
        {
            double requiredFuel = distance * _fuelConsumption;
            if (requiredFuel <= _fuelQuantity)
            {
                _fuelQuantity -= requiredFuel;
                System.Console.WriteLine($"Car travelled {distance} km ");
            }
            else
            {
                throw new ArgumentException("Car needs to refueling");
            }

        }

        public double GetFuelQuantity() => _fuelQuantity;

        public void Refuel(int amount)
        {
            _fuelQuantity += amount;
            System.Console.WriteLine($" {amount} Liter successfully refuel on Car");
        }



    }
}