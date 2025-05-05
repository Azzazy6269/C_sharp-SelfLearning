
class SmartHome<T> where T : ISmartControl
{
    List<T> Appliances = new List<T>();
    public void AddAppliance(T SmartTool)
    {
        Appliances.Add(SmartTool);
    }
    public void RemoveAppliance(T SmartTool)
    {
        Appliances.Remove(SmartTool);
    }
    public void ControlAppliance(T SmartTool)
    {
        int index = Appliances.IndexOf(SmartTool);
        if (index < 0)
        {
            throw new Exception("Device not found");
        }
        Appliances[index].TogglePower();
        if (notificationHandler != null)
            notificationHandler($"Notification :{(Appliances[index].Status ? "Turn ON" : "Turn OFF")} {Appliances[index].Name}   ");
    }
    public void ShowApplianceStatus(T SmartTool)
    {
        int index = Appliances.IndexOf(SmartTool);
        if (index < 0)
        {
            throw new Exception("Device not found");
        }
            Appliances[index].GetStatus();
    }

    public delegate void ApplianceNotificationHandler(string message);
    public event ApplianceNotificationHandler notificationHandler;

}

/* SmartHome<T> Where T : ISmartControl can treat only with the elements that implemented in ISmartHome
   public interface ISmartControl
{
    public void Control();
    public void GetStatus();
    public void Reset();
}
 
 so i couldn't write : 
    notificationHandler($"Notification :{(Appliances[index].Status ? "Turn ON" : "Turn OFF")} {Appliances[index].Name}   ");
 as Status and Name was fields in Appliance

 so i solved it by add Name and Status to ISmartHome interface 
  public interface ISmartControl
  {
    public void Control();
    public void GetStatus();
    public void Reset();
    public string Name { get; }
    public bool Status { get; }
  }
 and modify the fields' names in Appliance to _name , _status
 
 */