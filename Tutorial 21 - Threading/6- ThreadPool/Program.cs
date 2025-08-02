class Program
{
    static void Main(string[] args)
    {
        //1
        ThreadPool.QueueUserWorkItem(new WaitCallback(Print));

        //2
        Task.Run(Print);
        Console.ReadKey();
    }
    private static void Print(object state)
    {
        Console.WriteLine($"Thread ID : {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine($"IsPooled thread : {Thread.CurrentThread.IsThreadPoolThread}");
        Console.WriteLine($"is backGround : {Thread.CurrentThread.IsBackground}");
    }
    private static void Print()
    {
        Console.WriteLine($"Thread ID : {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine($"IsPooled thread : {Thread.CurrentThread.IsThreadPoolThread}");
        Console.WriteLine($"is backGround : {Thread.CurrentThread.IsBackground}");
    }
}
/*
 What is a ThreadPool?
The ThreadPool in .NET is a ready-made collection of threads that is managed automatically by the .NET runtime.

Instead of creating a new thread every time you want to do some background work (which is expensive in terms of system resources), the ThreadPool lets you reuse existing threads from the pool. This provides several benefits:

✅ Benefits of ThreadPool:
Faster: No need to constantly create and destroy threads.

More memory-efficient: Reusing threads means less overhead.

Scalable: The system can manage many tasks efficiently without creating thousands of threads.

Automatically managed: The .NET runtime handles the size of the pool and schedules tasks efficiently.
 */