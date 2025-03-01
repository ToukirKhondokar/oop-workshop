using Vehicle_Simulation.Entites;
using Vehicle_Simulation.Interface;
 
 class Program
{
    static void Main()
    {
        ICar car= new Car(15.2,2.4);
    

        ITruck truck= new Truck(30,1.2);   // (fuel quantity, fuel consumption_per_km)
        try
        {


        truck.Drive(10);
        car.Refuel(30);
        car.Drive(20);
        
        }
        catch (System.Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
           
        }


    }
}