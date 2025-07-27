using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var wallet = new Wallet("Issam", 80);
        wallet.RunRandomTransactions();
        Console.WriteLine($"{wallet}");
        wallet.RunRandomTransactions();
        Console.WriteLine($"{wallet}");

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

    public void Dept (int amount)
    {
        Bitcoins -= amount;
    }

    public void Credit(int amount)
    {
        Bitcoins += amount;
    }

    public void RunRandomTransactions()
    {
        int[] amounts = { 10, 22, 13, 4, 35, -10,-17,-21,-40,-2};
        foreach(int amount in amounts)
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
            Console.WriteLine($"Process ID : {Process.GetCurrentProcess().Id}");
            Console.WriteLine($"Thread ID : {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Processor ID : {Thread.GetCurrentProcessorId()}");

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