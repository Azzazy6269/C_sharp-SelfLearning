using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        A a1 = new A();
        A.B b1 = new A.B();
        b1.modify_xValue(13);
    }
}

class A
{
    private int x;
   public class B
    {
        A a1 = new A();
        public void modify_xValue(int xValue)
        {
            a1.x = xValue;
        }
    }
}