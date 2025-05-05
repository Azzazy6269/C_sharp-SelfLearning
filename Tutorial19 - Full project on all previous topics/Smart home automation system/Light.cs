sealed class Light : Appliance , ISmartControl
{
    private byte Brightness { get; set; }
    private string Color { get; set; }
    public Light(string name, int id, bool status, byte brightness, string color) : base(name,id,status)
    {
        this.Brightness = brightness;
        this.Color = color;
    }
    public Light(string name, int id, bool status) : base(name, id, status)
    {
        Brightness = 125;
        Color = "White";
    }
    public void SetBrightness(byte brightness)
    {
        this.Brightness = brightness;
        Console.WriteLine($"brightness of {Name} became {brightness}");
    }
    public void SetColor(string color)
    {
        this.Color = color;
        Console.WriteLine($"color of {Name} became {color}");
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
        Console.WriteLine($"Status of {Name} is{(Status ? "ON":"OFF")} , Brightness = {Brightness} , Color = {Color}");
    }

    public void Reset()
    {
        Brightness = 125;
        Color = "white";
        Console.WriteLine($"{Name} has returned to its default settings ");
    }

}
