using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var w = new Wallet("Issam", 100);
        Thread.CurrentThread.Name = "Main thread";


        Thread t1 = new Thread(w.RunRandomTransactions);
        Console.WriteLine("---------Naming---------");
        Console.WriteLine($"Default name : {t1.Name}");
        t1.Name = "T1";
        Console.WriteLine($"New name : {t1.Name}");


        Console.WriteLine("\n---------RunRandomTransactions()---------");
        w.RunRandomTransactions();


        Console.WriteLine("\n---------IsBackGround()---------");
        Console.WriteLine($"t1 is background ? {t1.IsBackground}");

    }
}

class Wallet
{
    public Wallet(string name, int bitcoins)
    {
        this.name = name;
        Bitcoins = bitcoins;
    }

    public string name { get; private set; }
    public int Bitcoins { get; private set; }

    public void Dept(int amount)
    {
        Bitcoins -= amount;
        Console.WriteLine($"Process ID : {Process.GetCurrentProcess().Id}");
        Console.WriteLine($"Thread ID : {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine($"Processor ID : {Thread.GetCurrentProcessorId()}");
    }

    public void Credit(int amount)
    {
        Bitcoins += amount;
        Console.WriteLine($"Process ID : {Process.GetCurrentProcess().Id}");
        Console.WriteLine($"Thread ID : {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine($"Processor ID : {Thread.GetCurrentProcessorId()}");
    }

    public void RunRandomTransactions()
    {
        int[] amounts = { 10, 22, 13, 4, 35, -10, -17, -21, -40, -2 };
        foreach (int amount in amounts)
        {
            int absValue = Math.Abs(amount);
            if (amount < 0)
            {
                Dept(absValue);
            }
            else
            {
                Credit(absValue);
            }
            

            /* Process ID is constant for each runtime
             * Thread ID is constant for each runtime and it's always = 1 
             * Processor ID differs in the same runtime as "Thread Scheduling" distributes loads over logical processors to keep it balanced
            */

            /*
             * process ID (PID) is constant and have one thread for some programs in runtime like C# console , Adobe reader .
             * process ID (PID) is constant and have tens or hundrads threads for some complex programs like Microsoft word , photoshop .
             * process ID (PID) is several in some complex programs like Chrome which have seperate process for each Tab 
                for security and to prevent error from one tab to damage another tab 
             */
        }
    }
    public override string ToString()
    {
        return $"--------------\n{name} -> {Bitcoins}\n----------------\n";
    }


}