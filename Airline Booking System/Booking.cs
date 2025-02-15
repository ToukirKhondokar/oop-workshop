public class Booking
{
    private Customer _customer;
    public Customer Customer { get => _customer; set => _customer = value; }

    private Flight _flight;
    public Flight Flight { get => _flight; set => _flight = value; }

    public Booking(Customer customer, Flight flight)
    {
        this._customer = customer;
        this._flight = flight;
    }
}
