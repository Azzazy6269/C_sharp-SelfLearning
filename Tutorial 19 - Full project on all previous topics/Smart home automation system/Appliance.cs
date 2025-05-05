
public abstract class Appliance
{
    protected string _name;
    protected int _id;
    protected bool _status;

    public string Name => _name;
    public bool Status => _status;

    protected Appliance(string name, int id, bool status)
    {
        this._name = name;
        this._id = id;
        this._status = status;
    }
    protected void TurnOn()
    {
        _status = true;
        Console.WriteLine($"{_name} is turned on");
    }
    protected void TurnOff()
    {
        _status = false;
        Console.WriteLine($"{_name} is turned off");
    }
    

}

public interface ISmartControl
{
    public void TogglePower();
    public void GetStatus();
    public void Reset();
    public string Name { get; }
    public bool Status { get; }
}