using LegacyLibrary;

namespace ChargingApp;
public class MicroUsbToUsbCAdapter : IUsbCCharger
{
    private readonly MicroUsbCharger _microUsb;
    public MicroUsbToUsbCAdapter(MicroUsbCharger microUsb)
    {
        _microUsb = microUsb;
    }

    public void ChargePhone()
    {
        Console.WriteLine("Adapter converting USB-C to Micro USB");
       
    }
}
