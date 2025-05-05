using System.Drawing;

sealed class Thermostat : Appliance , ISmartControl
{
    private byte Temperature { get; set; }
    private string Mode { get; set; }
    public Thermostat(string name, int id, bool status, byte temperature, string mode) : base(name, id, status)
    {
        this.Temperature = temperature;
        this.Mode = mode;
    }
    public Thermostat(string name, int id, bool status) : base(name, id, status)
    {
        Temperature = 25;
        Mode = "cooling";
    }
    public void SetTemperature(byte temperature)
    {
        this.Temperature = temperature;
        Console.WriteLine($"temperature became {temperature}");

    }
    public void SwitchMode()
    {
        this.Mode = Mode == "cooling" ? "heating" : "cooling";
        Console.WriteLine($"mode of {Name} became {Mode}");
    }

    public void TogglePower()
    {
        if (Status)
            TurnOff();
        else
            TurnOn();
    }

    public void GetStatus()
    {
        Console.WriteLine($"Status of {Name} is {(Status ? "ON" : "OFF")} , Temperature = {Temperature} , Mode = {Mode}");
    }
    public void Reset()
    {
        Temperature = 25;
        Mode = "cooling";
        Console.WriteLine($"{Name} has returned to its default settings ");
    }
}
