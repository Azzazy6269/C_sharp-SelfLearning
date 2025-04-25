using System.Linq.Expressions;

class Program 
{ 
    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(),out int x);
        int.TryParse(Console.ReadLine(),out int y);
        divide(x, y);
        Multiply(x, y);
        Add(x, y);
        Substract(x, y);


    }
    static void divide(int x, int y)
    {

        try
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        catch (DivideByZeroException) 
        {
            Console.WriteLine("Divided by zero");
        }
        catch (ArgumentNullException) 
        {
            Console.WriteLine("null value");
        }
        catch(Exception) 
        {
            Console.WriteLine("General exception");
        }
        finally
        {
            Console.WriteLine("End of process");
        }
    }

    static void Multiply(int x, int y)
    {
        try
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        catch (ArgumentNullException ex) when (ex.ParamName == "x" || ex.ParamName == "y")//filter to be checked . if it's false the exception will not be thrown
        {
            Console.WriteLine("null value");
        }
        catch (Exception ex) when (ex.Source == "Calculator")  
        {
            Console.WriteLine("General exception");
        }
        finally
        {
            Console.WriteLine("End of process");
        }
    }

    static void Add(int x, int y)
    {
        try
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        catch (ArgumentNullException ex) 
        {
            Console.WriteLine("null value");
        }
        catch (Exception ex) 
        {
            Console.WriteLine("General exception");
        }
        finally
        {
            Console.WriteLine("End of process");
        }
    }

    static void Substract(int x, int y)
    {
        try
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        catch (ArgumentNullException ex) 
        {
            Console.WriteLine("null value");
        }
        catch (Exception ex) 
        {
            Console.WriteLine("General exception");
        }
        finally
        {
            Console.WriteLine("End of process");
        }
    }
}

/* In divide :
 * the first exception will be thrown if y = 0
 * the second exception will be thrown if x or y = null
 * the general exception will be thrown if there's an exception that i haven't defined 
 * finally code will execute in all cases even there's no exceptions in try code  
 */


/*
NullReferenceException happens when you try to use an object that is null.
ArgumentNullException happens when you pass null to a method that doesn't allow it.
 */