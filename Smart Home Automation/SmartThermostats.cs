public class SmartThermostats : ISmartDevice,ITemperatureControl
{
    private double _temperature;
    public double Temperature{get=>_temperature; set=>_temperature=value;}

    public SmartThermostats(string name){
        this.DeviceName=name;
    }

    private string? _deviceName;
    public string? DeviceName { get=>_deviceName; set=>_deviceName=value; }

     public void Settemperature(double temperature){
        if(temperature<0 || temperature>100){
            throw new ArgumentException("Temperature must be between 0 and 100.");
        }
        Temperature=temperature;
     } 
     

     public void TurnOn() => System.Console.WriteLine($"{DeviceName} is turned on.");
     public void TurnOff() => System.Console.WriteLine($"{DeviceName} is turned off.");



}
