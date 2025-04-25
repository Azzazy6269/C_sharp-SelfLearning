class Program
{
    static void Main(string[] args)
    {
        try
        {
            print1();
            print2();
            print3();
            print4();
            print5();
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        print1();
        print2();
        print3();
    }
    static void print1() => Console.WriteLine("1");
    static void print2() => Console.WriteLine("2");
    static void print3() => Console.WriteLine("3");
    static void print4() => throw new NullReferenceException("couldn't print 4");
    static void print5() => Console.WriteLine("1");

}


/*What happens when an Exception occurs in code wrapped with a try-catch?
1- The code inside the try block executes normally until an exception occurs.
2- As soon as an exception is thrown, the program immediately stops at the line where the error happened.
3- Then, the program jumps to the catch block that matches the type of the exception.
4- The code inside the catch block is executed.
5- If there is a finally block, it will always execute, whether an exception happened or not.
6- The program then continues running normally after the try-catch block — unless the exception was rethrown or you stopped the execution manually.
 */

/*
 *The first 3 methods (print1, print2, print3) run normally and print their output.
 *print4() throws a NullReferenceException.
 *As soon as the exception occurs, execution stops at that line and immediately jumps to the catch block.
 *print5() will not be executed because the exception interrupted the flow before it.
 *After the catch block, the rest of the code outside the try block continues as usual.
 */