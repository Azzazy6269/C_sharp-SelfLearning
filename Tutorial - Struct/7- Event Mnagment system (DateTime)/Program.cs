class Program
{
    static void Main(string[] args)
    {
        Event ZagEng = new Event("Openning day season 2025",new DateTime(2025,4,15 , 20,30,00),new DateTime(2025,4,15,21,30,00));
        ZagEng.ShowInfo();
    }
}

struct Event
{
    readonly string _eventName;
    readonly DateTime _start;
    readonly DateTime _end;
    readonly TimeSpan _duration;

    public Event(string eventName , DateTime start , DateTime end )
    {
        this._eventName = eventName;
        this._start = start;
        this._end = end;
        this._duration = end - start;
    }

    public string ShowStatus()
    {
        string Status;
        if (DateTime.Now < _start) { Status = "Upcoming"; }
        else if (DateTime.Now > _start && DateTime.Now < _end) { Status = "Ongoing"; }
        else {Status = "Terminated"; }
        return Status;
    }

    public void ShowInfo()
    {
        TimeSpan remaining = _start - DateTime.Now;
        Console.WriteLine($"Event Name : {_eventName}\n" +
                          $"Start Date : {_start}\n" +
                          $"End Date   : {_end}\n" +
                          $"Duration   : {_duration}" 
                          );
        switch (ShowStatus())
        {
            case "Upcoming":
                Console.WriteLine($"Event starts in {remaining.Days} days , {remaining.Hours} hours , {remaining.Minutes} minutes , {remaining.Seconds} seconds\n");
                break;
            case "Ongoing":
                Console.WriteLine("Event is running now");
                break;
            case "Terminated":
                Console.WriteLine("Event is finished");
                break;
            default:
                break;
        }
    }

}