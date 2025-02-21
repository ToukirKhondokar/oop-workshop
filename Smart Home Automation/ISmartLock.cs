public interface ISmartLock:ISmartDevice
{
    void Lock();
    void Unlock();
    void LogAccess();
}