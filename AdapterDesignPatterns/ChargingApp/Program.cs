using LegacyLibrary;

namespace ChargingApp;

internal class Program
{
    static void Main(string[] args)
    {
        MicroUsbCharger oldCharger = new MicroUsbCharger();
        var adapter = new MicroUsbToUsbCAdapter(oldCharger);
        adapter.ChargePhone();

    }
}
