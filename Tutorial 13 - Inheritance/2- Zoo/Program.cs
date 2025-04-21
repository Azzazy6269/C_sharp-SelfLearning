using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        wild Bison1 = new wild(17, "3egl",8, "North carolina", false);
        Bison1.eat("grass");
        Bison1.grow();
        Bison1.makeSound();
        Bison1.takesVaccine("flu vaccine");
        Bison1.die();
        Console.WriteLine(Bison1.ToString());

    }
}
