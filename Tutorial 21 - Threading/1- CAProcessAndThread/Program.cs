using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Process ID : {Process.GetCurrentProcess().Id}");
        Console.WriteLine($"Thread ID : {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine($"Processor ID : {Thread.GetCurrentProcessorId()}");
        Console.ReadKey();
    }
}
