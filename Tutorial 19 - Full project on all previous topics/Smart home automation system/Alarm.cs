using System.Drawing;

sealed class Alarm : Appliance , ISmartControl
{
    private byte Volume { get; set; }
    private string AlarmType { get; set; }
    private bool Activated { get; set; }
    public Alarm(string name, int id, bool status, byte volume, string alarmType) : base(name, id, status)
    {
        this.Volume = volume;
        this.AlarmType = alarmType;
    }
    public Alarm(string name, int id, bool status) : base(name, id, status)
    {
        this.Volume = 255;
        this.AlarmType = "Unknown";
    }
    public void SetVolume(byte volume)
    {
        this.Volume = volume;
        Console.WriteLine($"{Name}'s volume became {Volume} ");
    }
    public void Activate()
    {
        this.Activated = true;
        Console.WriteLine($"{Name} is activated ");
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
        Console.WriteLine($"Status of {Name} is{(Status ? "ON" : "OFF")} ");
    }

    public void Reset()
    {
        Volume = 255;
        Activated = false;
        Console.WriteLine($"{Name} has returned to its default settings ");
    }
}