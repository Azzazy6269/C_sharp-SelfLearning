using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

class Program
{
    delegate void TimerCall();

    static void Main(string[] args)
    {
        DateTime date = new DateTime(1999, 11, 2);
        date = date.AddMonths(2);
        Console.WriteLine($"Year after AddMonths: {date.Year}");

        TimeSpan between = date - new DateTime(1970, 5, 25, 18, 30, 00);
        TimeSpan tillnow = DateTime.Now - date;

        Console.WriteLine($"Time between dates: {between.Days} days");
        Console.WriteLine($"Time till now: {tillnow.Days} days");

        static void first()
        {
            Console.WriteLine("Timer is alerting");
        }
        TimerCall call = first; 
        Timer t1 = new Timer(_=>call(),null,0,10000);

        Console.ReadKey();

        
    }
    

}
