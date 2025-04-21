class Program
{
    static void Main(string[] args)
    {
        Vehicle v1 = new Lorry("Caterpillar", "avb", 2018);
        ILoader v2 = new Lorry("Caterpillar", "xyz", 2007);
        IDrivable v3 = new Lorry("Caterpillar", "sfd", 2020);
        IMaintainable v4 = new Lorry("Caterpillar", "jhf", 2024);
        Lorry v5 = new Lorry("Caterpillar", "qwe", 2022);

        v1.move(); // v1 can use move() , stop() , fuel() , Maintain() because they are declared in Vehicle class but can't use Load() , Unload() as Vehicle class has no idea about them
        v2.Load(); // v2 can't use any method or variable outside those who are declared in ILoader 
        v3.move(); // v3 can't use any method or variable outside those who are declared in IDrivable 
        v4.Maintain(); // v4 can't use any method or variable outside those who are declared in IMaintainable 
        v5.Fuel(); // v4 can use all members move() , stop() , Load() , Unload() , Maintain() , fuel() as they'll are visible for Caterpillar class
    }
}

interface ILoader
{
    void Load();
    void Unload();
}
interface IDrivable
{
    void move();
    void stop();
}

interface IMaintainable
{
    void Maintain();
}

/* an interface is like a contract that defines a set of method signatures, properties, events, or indexers—but without any implementation.
 * Any class or struct that implements the interface agrees to implement all its members .
 * An interface defines what a class should do, not how .
 * Classes can implement multiple interfaces (unlike inheritance, which is single in C#) .
 * Interface members are public by default and cannot have access modifiers .
 * You cannot create an instance of an interface directly .
 */