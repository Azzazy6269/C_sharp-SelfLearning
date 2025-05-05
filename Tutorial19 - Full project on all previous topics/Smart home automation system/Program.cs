using System.Net.NetworkInformation;
using System.Xml.Linq;

class Progarm
{
    static void Main(string[] args)
    {
        var myHome = new SmartHome<ISmartControl>();
        var room1Light = new Light("bedroom1 light", 1, false);
        var room2Light = new Light("bedroom2 light", 2, true);
        var room3Light = new Light("salon light", 3, true);
        var room4Light = new Light("Kitchen light", 4, false);
        var thermo = new Thermostat("air conditioner", 5, true, 22, "cooling");
        var alarm1 = new Alarm("Alarm1", 6, false, 255, "gas leak");
        var alarm2 = new Alarm("Alarm2", 7, false, 255, "fire");

        try
        {
            myHome.AddAppliance(room1Light);
            myHome.AddAppliance(room2Light);
            myHome.AddAppliance(room3Light);
            myHome.AddAppliance(room4Light);
            myHome.AddAppliance(thermo);
            myHome.AddAppliance(alarm1);
            myHome.AddAppliance(alarm2);

            myHome.notificationHandler += SwitchStatus;

            myHome.ControlAppliance(room4Light);
            myHome.ControlAppliance(room4Light);
            myHome.ControlAppliance(thermo);

        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }

    static void SwitchStatus(string message)
    {
        Console.WriteLine(message);
    }

}


