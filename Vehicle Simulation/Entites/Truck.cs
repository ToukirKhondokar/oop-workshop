using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Simulation.Interface;

namespace Vehicle_Simulation.Entites
{
    public class Truck : ITruck
    {
        private double _fuelQuantity;
        public double FuelQuantity { get => _fuelQuantity; set => _fuelQuantity = value; }

        private double _fuelConsumption;
        public double FuelConsumption { get => _fuelConsumption; set => _fuelConsumption = value; }

        public Truck(double fuelQuantity,double fuelConsumption){
            _fuelQuantity = fuelQuantity;
            _fuelConsumption = fuelConsumption+ITruck.AirConditionerExtraConsumption;
        }


        public void Drive(int distance)
        {
             double requiredFuel=distance* _fuelConsumption;
            if (requiredFuel <= _fuelQuantity)
            {
                _fuelQuantity-=requiredFuel;  
                System.Console.WriteLine($"truck travelled {distance} km ");  
            }else
            {
                System.Console.WriteLine($"Truck needs refueling");    
            }
             
        }

        public double GetFuelQuantity()=> _fuelQuantity;

        public void Refuel(int amount)
        {
           _fuelQuantity += amount * ITruck.RefuelEfficiency; 
        }
    }
}