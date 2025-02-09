public class Car
{
    private string _carName;
    public string CarName { get => _carName; set { _carName = value; } }
    private string _brandName;
    public string BrandName { get => _brandName; set { _brandName = value; } }
    private string _carId;
    public string CarId { get=> _carId; set{_carId=value;} }
   




    public Car()
    {
        int RentalAmount = 0;
    }
    public Car(string BrandName, string CarName,string CarId) : this()
    {
        _carName = CarName;
        _brandName = BrandName;
        _carId = CarId;
    }




}