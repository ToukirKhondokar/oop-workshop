
public class Program
{
    public static void Main()
    {

        try
        {
            //Car car1 = new Car();
            CarRentalService rentalService = new CarRentalService();
            rentalService.AddCar(new Car("Toyota", "primeo","123-44"));
            rentalService.AddCar(new Car("Honda", "civic","123-23"));
            rentalService.AddCar(new Car("Mitshubishi", "lancer","123-65"));
            rentalService.AddCar(new Car("Bmw", "cls200","123-98"));
            rentalService.AddCar(new Car("Nissan", "X-trail","123-00"));



            rentalService.RentCar(100000,1000);
            Car car = rentalService.DisplayCar("123-65");
        }
        catch (System.Exception ex )
        {

            Console.WriteLine($"{ ex.Message}");
        }
    }
}
