public class Flight
{
    private string? _flightNumber;
    public string? FlightNumber { get => _flightNumber; set => _flightNumber = value; }

    private string? _destination;
    public string? Destination { get => _destination; set => _destination = value; }

    private int? _flightId;
    public int? FlightId { get => _flightId; set => _flightId = value; }

    private int? _availableSeats;
    public int? AvailableSeats { get => _availableSeats; set => _availableSeats = value; }

    private List<Booking>? _bookings;
    public List<Booking>? Bookings { get => _bookings; set => _bookings = value; }


    public Flight(string flightNumber, string destination, int flightId, List<Booking> bookings, int availableSeats)
    {
        this.FlightNumber = flightNumber;
        this.Destination = destination;
        this.FlightId = flightId;
        this.Bookings = bookings;
        this.AvailableSeats = availableSeats;
    }

    public void BookSeat(Customer customer)
    {
        if (AvailableSeats > 0)
        {
            Booking booking = new Booking(customer, this);
            Bookings?.Add(booking);
            AvailableSeats--;
        }
    }

    public void CancelSeat(Customer customer)
    {
        var booking = Bookings?.FirstOrDefault(b => b.Customer == customer);
        if (booking != null)
        {
            Bookings?.Remove(booking);
            AvailableSeats++;
        }
    }



}