class Program
{
    static void Main(string[] args)
    {
        Animal a1 = new Animal();
        a1.move();

        Eagle e1 = new Eagle();
        e1.move();

        e1.EagleEat();

        /* UpCasting : Creating a reference of the base class to refer to an object of the derived class.
         * You store a derived class object in a variable of the base class type.
         * it will have the base class elements(fields,properties,methods,.....etc) 
         */
        Animal a2 = e1; //upcasting is implicit . you don't have to write (Animal)e1
        a2.move();


        /* DownCasting : Casting a base class reference back to a derived class reference
         * It is used to treat an object (that was previously upcasted) as an instance of its original derived class.
         * now, it will have the derived class elements(fields,properties,methods,.......etc)
         */
        Eagle e2 = (Eagle)a2; //downcasting is explicit . you have to write (Eagle)e2
        e2.fly();


        /* try to Cast to Falcon */
        Falcon f = a2 as Falcon; // if a2 isn't Falcon f will store null
        if(a2 is Falcon)
        {
            Console.WriteLine("a2 is Falcon");
            f = (Falcon)a2;
        }
        else
        {
            Console.WriteLine($"a2 is not Falcon ,it's {a2.GetType()} ");
        }

        //Animal x = new Eagle(); correct
        //Eagle Y = new Animal(); Error
    }
}

class Animal
{
    public void move() // public is visible for all classes (Eagle,Falcon & Program)
    {
        Console.WriteLine("Moving");
    }
    protected void eat() /* protected is visible only for the inheritance class
                            so it can be called in Eagle,Falcon class and in Animal class
                            but it can't be called in Main (not for Eagle,Falcon object neither Animal object)
                          */ 
    {
        Console.WriteLine("Eating");
    }
}

class Eagle : Animal
{
    public void fly()
    {
        Console.WriteLine("Flying");
    }
    public void EagleEat() 
    {
        eat();
    }

}

class Falcon : Animal
{
    public void fly()
    {

    }
    public void FalconEat()
    {
        eat();
    }
    
}