// See https://aka.ms/new-console-template for more information
class Program{

    static void Main()
    {
        try{
        SmartHomeSystem smartHomeSystem=new SmartHomeSystem();

        var light = new SmartLight("Living Room Light");
        var smartLocklock = new SmartLock("Front Door Lock");
        var thermostat = new SmartThermostats("Living Room Thermostat");
        var camera = new SecurityCamera("Front Door Camera");

        smartHomeSystem.AddDevice(light);
        smartHomeSystem.AddDevice(smartLocklock);
        smartHomeSystem.AddDevice(thermostat);
        smartHomeSystem.AddDevice(camera);

        smartHomeSystem.TurnOnAllDevices();
        light.Dim(50);
        thermostat.Settemperature(75);
        camera.StartRecording();
        smartLocklock.Lock();
        smartHomeSystem.TurnOffAllDevices();
        }catch(Exception ex){
            System.Console.WriteLine(""+ex.Message);
        }
    }
}
