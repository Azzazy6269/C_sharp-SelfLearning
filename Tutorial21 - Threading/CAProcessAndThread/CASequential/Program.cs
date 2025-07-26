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
                Dept(amount);
            }
            else
            {
                Credit(absValue);
            }
            Console.WriteLine($"Process ID : {Process.GetCurrentProcess().Id}");
            Console.WriteLine($"Thread ID : {Thread.CurrentThread.ManagedThreadId}");
        }
    }
    public override string ToString()
    {
        return $"{name} -> {Bitcoins}";
    }


}