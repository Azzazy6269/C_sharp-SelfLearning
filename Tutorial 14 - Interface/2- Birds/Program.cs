class Program
{
    static void Main(string[] args)
    {
        IWalk p1 = new Pigeon(); // p1 can treat only with move() , stop() from IWalk interface
        p1.move();
        p1.stop();
        

        IFly p2 = new Pigeon(); // p2 can treat only with move() , stop() from IFly interface
        p2.move();
        p2.stop();

        Pigeon p3 = new Pigeon();
                                  /* you can't never treat with move() , stop() of any 2 interfaces 
                                   * in explicit implementation you have to declare the object as a type of interface to use it's members
                                   */

        Ostrich o = new Ostrich();// o can use move() , stop() as it's implicit implementation
        o.move();

    }
}
interface IWalk
{
    public void move();
    void stop();
}
interface IFly
{
    void move();
    void stop();
}

interface IEat
{
    void eat()
    {
        Console.WriteLine("eating");
    }
    /*this is default interface implementation 
      you can't call p3.eat() until :
      1) you override and implement the method again in pigeon class as it wasn't implemented before
      2) or Write IEat p3 =new Pigeon(); now you can use it p3.eat();
     */
}