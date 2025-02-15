public class Program
{
    static void Main()
    {
        AirlineReservation system = new AirlineReservation();


        try
        {

            // Adding flights
            system.AddFlight(new Flight("AI101", "New York", 3, new List<Booking>(), 3));

            system.AddFlight(new Flight("BA202", "London", 2, new List<Booking>(), 2));

            // Creating customers
            Customer customer1 = new Customer("10", "John Doe", "john@example.com");
            Customer customer2 = new Customer("11", "Alice Smith", "alice@example.com");

            // Display available flights
            system.DisplayAllFlights();

            // Booking seats
            var BookSeat = system.BookFlight("AI101", customer1);
            BookSeat = system.BookFlight("AI101", customer2);
            System.Console.WriteLine($"{BookSeat} for {customer1.CustomerName}");
            System.Console.WriteLine($"{BookSeat} for {customer2.CustomerName}");



            // Display alll flights 
            system.DisplayAllFlights();

            // Cancel a booking
            var CancelFlight = system.CancelFlight("AI101", customer1);
            System.Console.WriteLine($"{CancelFlight}");

            // Display flights after cancellation
            system.DisplayAllFlights();

        }
        catch (Exception message)
        {
            Console.WriteLine($"Error: {message.Message}");

        }

    }
}
