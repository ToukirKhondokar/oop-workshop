public class CarRentalService
{
    public List<Car> CarInventantory = new List<Car>();
    public double CarRentAmount { get; private set; }
    private bool _isAvailable;
    public bool IsAvailable
    {
        get => CarRentAmount > 0;
        set => _isAvailable = value;
    }
    public DateTime MaintainanceStartDate { get; set; }
    public DateTime MaintainanceEndDate { get; set; }

    public void AddCar(Car car)
    {
        CarInventantory.Add(car);

    }

    public Car DisplayCar(string id)
    {
        var car = CarInventantory.First(c => c.CarId == id);
        return car;
    }

    public void SetMaintainancePeriod(DateTime startDate, DateTime endDate) 
    {
        MaintainanceStartDate = startDate;
        MaintainanceEndDate = endDate;
    }

    private bool GetAvailability(DateTime rentDate) 
    {
        bool IsAvailable = rentDate >= MaintainanceStartDate && rentDate <= MaintainanceEndDate;
        return IsAvailable;
    }




    public void RentCar(double amount, double CarRentAmount, DateTime bookingDate)
    {
        if (!GetAvailability(bookingDate)) 
        {
            throw new ArgumentException("Car is in Maintaninence,can not book the car");
        } 

        if (!IsAvailable)
        {
            throw new Exception("Car is not available at this moment");
        }
        if (amount < 0)
        {
            throw new Exception("Amount can not be negative");
        }
        else
        {
            CarRentAmount += amount;

        }

    }

}