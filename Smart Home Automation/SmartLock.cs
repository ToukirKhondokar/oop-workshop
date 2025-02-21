public class SmartLock : ISmartLock
{
    public SmartLock(string name)
    {
        this.DeviceName = name;
    }
    private string? _deviceName;
    public string? DeviceName { get => _deviceName; set => _deviceName = value; }

    public void Lock() => System.Console.WriteLine($"{DeviceName} is locked.");
    public void Unlock() => System.Console.WriteLine($"{DeviceName} is unlocked.");
    public void LogAccess() => System.Console.WriteLine($"{DeviceName} access logged.");

    public void TurnOn() => System.Console.WriteLine($"{DeviceName} is turned on.");
    public void TurnOff() => System.Console.WriteLine($"{DeviceName} is turned off.");
}

