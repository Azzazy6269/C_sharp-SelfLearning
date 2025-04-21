class Pigeon : IWalk, IFly, IEat
{
     void IWalk.move() 
    {
        Console.WriteLine("Pigeon is walking");
    }

    void IFly.move()
    {
        Console.WriteLine("Pigeon is flying");
    }

    void IWalk.stop()
    {
        Console.WriteLine("Pigeon stopped walking");
    }

    void IFly.stop()
    {
        Console.WriteLine("Pigeon stopped flying");
    }
}


/* you have to implement interfaces explicity as both two interfaces have move() , stop()
 * you can't add a modifier (public,private,protected) to explicit implementation
 */