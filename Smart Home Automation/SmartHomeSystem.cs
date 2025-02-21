public class SmartHomeSystem
{
    private List<ISmartDevice> _devices=new List<ISmartDevice>();
    public List<ISmartDevice> Devices { get=>_devices; set=>_devices=value; }
    
    public SmartHomeSystem(){
        
    }

    public void AddDevice(ISmartDevice device){
        _devices.Add(device);
    }

    public void TurnOnAllDevices(){
        foreach (var item in _devices)
        {
            item.TurnOn();
        }
    }

    public void TurnOffAllDevices(){
        foreach (var item in _devices)
        {
            item.TurnOff();
        }
    }


}
