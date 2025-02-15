public class AirlineReservation
{
    private List<Flight>? _flights;
    public List<Flight>? Flights { get => _flights; set => _flights = value; }


    public void AddFlight(Flight flight)
    {
        Flights?.Add(flight);
    }

    public AirlineReservation()
    {
        _flights = new List<Flight>();
    }

    public string BookFlight(string flightNumber, Customer customer)
    {
        var flight = Flights?.FirstOrDefault(f => f.FlightNumber == flightNumber);
        if (flight != null)
        {
            flight.BookSeat(customer);
            return $"Flight {flightNumber} booked successfully";
        }
        return $"{flightNumber} not found";

    }

    public string CancelFlight(string flightNumber, Customer customer)
    {
        var flight = Flights?.FirstOrDefault(f => f.FlightNumber == flightNumber);
        if (flight != null)
        {
            flight.CancelSeat(customer);
            return $"Flight {flightNumber} cancelled successfully";
        }
        return $"{flightNumber} not found";
    }

    public string GetBookingDetails(string flightNumber)
    {
        var flight = Flights?.FirstOrDefault(f => f.FlightNumber == flightNumber);
        if (flight != null)
        {
            return $"Flight {flightNumber} details: {flight.Bookings}";
        }
        return $"{flightNumber} not found";
    }

    public void DisplayAllFlights()
    {
        if (Flights != null)
        {
            foreach (var flight in Flights)
            {
                Console.WriteLine($"Flight Number: {flight.FlightNumber}, Destination: {flight.Destination}, Available Seats: {flight.AvailableSeats}");
            }
            return;
        }
    }

}


