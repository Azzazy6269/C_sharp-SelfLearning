class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Memory used before creating garbage: {GC.GetTotalMemory(false):N0}"); // used memory in bytes without collecting
        Console.WriteLine($"Memory used After collection: {GC.GetTotalMemory(true):N0}"); // used memory in bytes after collecting

        makeSomeGarbage();
        Console.WriteLine($"Memory used before collection: {GC.GetTotalMemory(false):N0}"); // used memory in bytes without collecting
        Console.WriteLine($"Memory used After collection: {GC.GetTotalMemory(true):N0}"); // used memory in bytes after collecting

        makeSomeGarbage();
        Console.WriteLine($"Memory used before collection: {GC.GetTotalMemory(false):N0}"); // used memory in bytes without collecting
        GC.Collect(); // Garbage collect
        Console.WriteLine($"Memory used after collection: {GC.GetTotalMemory(true):N0}"); // used memory in bytes after collecting
        
    }
    static void makeSomeGarbage()
    {
        GarbageClass g;
        for (int i=0; i<1000; i++)
        {
            g = new GarbageClass();
        }
    }
}

class GarbageClass
{
    ~GarbageClass()
    {
        //write some cleaning up code here
    }
}