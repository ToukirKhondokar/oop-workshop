public class Customer
{
    private string? _customerId;
    public string? CustomerId { get => _customerId; set => _customerId = value; }

    private string? _customerName;
    public string? CustomerName { get => _customerName; set => _customerName = value; }

    private string? _customerEmail;
    public string? CustomerEmail { get => _customerEmail; set => _customerEmail = value; }

    public Customer(string customerId, string customerName, string customerEmail)
    {
        this.CustomerId = customerId;
        this.CustomerName = customerName;
        this.CustomerEmail = customerEmail;
    }
}

