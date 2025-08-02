using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        /* DeadLock bug happens when thread1 locks object A and wants to access object B but thread2 has locked object B and wants to 
           access object A ,so both threads are waiting
         * To avoid deadLock We use two methods :
          1) if(Monitor.TryEnter(to, 1000)){
             }
          2) by making the sequntial of locking depends on their id or on their hashCode 
         */
        var w1 = new Wallet(16, "Kareem", 100);
        var w2 = new Wallet(10, "joe", 100);
        var transfer1 = new TransferManager(w1, w2, 30);
        var transfer2 = new TransferManager(w2, w1, 40);
        Thread t1 = new Thread(transfer1.Transfer);
        Thread t2 = new Thread(transfer2.Transfer);
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        Console.WriteLine(w1);
        Console.WriteLine(w2);
    }
}

class Wallet
{
    private readonly object bitcoinsLock = new object();
    public Wallet(int id, string name, int bitcoins)
    {
        Name = name;
        Bitcoins = bitcoins;
        ID = id;
    }

    public string Name { get; private set; }
    public int Bitcoins { get; private set; }
    public int ID { get; set; }

    public void Dept(int amount)
    {
        if (Bitcoins >= amount)
        {
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
            if ((Bitcoins + amount) <= 1000)
            {
                Bitcoins += amount;
                Console.WriteLine($"Process ID : {Process.GetCurrentProcess().Id} ," +
                                  $" Thread ID : {Thread.CurrentThread.ManagedThreadId} ," +
                                  $"Processor ID : {Thread.GetCurrentProcessorId()} ");
            }
        }



    }

    public override string ToString()
    {
        return $"--------------\n{Name} -> {Bitcoins}\n----------------\n";
    }


}

class TransferManager
{
    private Wallet from;
    private Wallet to;
    private int amountToTransfer;
    Wallet lock1, lock2;

    public TransferManager(Wallet from, Wallet to, int amountToTransfer)
    {
        this.from = from;
        this.to = to;
        this.amountToTransfer = amountToTransfer;
        lock1 = (from.ID < to.ID) ? from : to;
        lock2 = (to.ID < from.ID) ? to : from;
    }

    public void Transfer()
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is trying to lock {from.Name}");
        lock (lock1)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} lock acquired {from.Name}");
            if (Monitor.TryEnter(lock2, 1000))
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} lock acquired {to.Name}");
                try
                {
                    from.Dept(amountToTransfer);
                    to.Credit(amountToTransfer);
                }
                catch
                {

                }
                finally
                {
                    Monitor.Exit(lock2);
                }
            }
            else
            {
                Console.WriteLine($"Unable to acquire lock on {to.Name}");
            }
        }

    }
}