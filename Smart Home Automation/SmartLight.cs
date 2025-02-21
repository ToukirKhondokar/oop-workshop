public class SmartLight : ILightControl
{

    private int _brightnessLevel;
    public int BrightnessLevel{get=>_brightnessLevel; set=>_brightnessLevel=value;}

    private string? _deviceName;
    public string? DeviceName { get=>_deviceName; set=>_deviceName=value; }


    public SmartLight(string name){
        this.DeviceName = name;
    }

    public void TurnOn() => System.Console.WriteLine($"{DeviceName} is turned on."); 
    public void TurnOff() => System.Console.WriteLine($"{DeviceName} is turned off.");

    public void Dim(int level)
    {
      if (level <0 || level >100)
      {
        throw new Exception ($"Brightness level must be between 0 and 100. ");
      }
      BrightnessLevel=level;
      System.Console.WriteLine($"{DeviceName} brightness set to {BrightnessLevel}%");
    }


}