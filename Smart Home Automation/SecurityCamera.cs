public class SecurityCamera : ISecurityCamera
{
    private string? _deviceName;
    public string? DeviceName { get=>_deviceName; set=>_deviceName=value; }

    public SecurityCamera(string name){
        this.DeviceName=name;
    }

    public void StartRecording() => System.Console.WriteLine($"{DeviceName} is recording.");
    public void DetectMotion() => System.Console.WriteLine($"{DeviceName} is detecting motion.");

    public void TurnOn() => System.Console.WriteLine($"{DeviceName} is turned on.");
    public void TurnOff() => System.Console.WriteLine($"{DeviceName} is turned off.");
    
    
    
    
}
