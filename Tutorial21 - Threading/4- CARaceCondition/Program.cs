using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var wallet1 = new Wallet("Issam", 50);
        Thread t1 = new Thread(() => wallet1.Dept(40));
        Thread t2 = new Thread(() => wallet1.Dept(30));

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
        Console.WriteLine(wallet1);

        // Race condition is a bug that occurs when two or more threads or processes access shared data at the same time which leads to wrong output
        // A race condition happened here as t1 and t2 depted 40 then 30 although it isn't allowed to go below 0 so balance became -20

        var wallet2 = new Wallet("Issam", 50);
        Thread t3 = new Thread(() => wallet2.Credit(40));
        Thread t4 = new Thread(() => wallet2.Credit(30));

        t3.Start();
        t4.Start();

        t3.Join();
        t4.Join();
        Console.WriteLine(wallet2);
        //Unlike Dept() , we used lock() in credit to prevent race conditions so the output will be right
    }
}

class Wallet
{
    private readonly object bitcoinsLock = new object();
    public Wallet(string name, int bitcoins)
    {
        this.name = name;
        Bitcoins = bitcoins;
    }

    public string name { get; private set; }
    public int Bitcoins { get; private set; }

    public void Dept(int amount)
    {
        if (Bitcoins >= amount)
        {
            Thread.Sleep(1000);
            Bitcoins -= amount;
            Console.WriteLine($"Process ID : {Process.GetCurrentProcess().Id} ," +
                              $" Thread ID : {Thread.CurrentThread.ManagedThreadId} ," +
                              $"Processor ID : {Thread.GetCurrentProcessorId()} ");
        }
    }

    public void Credit(int amount)
    {
        lock (bitcoinsLock)
        {
            if ((Bitcoins + amount) <= 100)
            {
                Thread.Sleep(1000);
                Bitcoins += amount;
                Console.WriteLine($"Process ID : {Process.GetCurrentProcess().Id} ," +
                                  $" Thread ID : {Thread.CurrentThread.ManagedThreadId} ," +
                                  $"Processor ID : {Thread.GetCurrentProcessorId()} ");
            }
        }



    }

    public override string ToString()
    {
        return $"--------------\n{name} -> {Bitcoins}\n----------------\n";
    }


}