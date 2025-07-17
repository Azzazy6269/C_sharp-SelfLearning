class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("First name :");
        var fname = Console.ReadLine();

        Console.WriteLine("Last name :");
        var lname = Console.ReadLine();

        Console.WriteLine("Hire date :");
        DateTime hireDate;
        if (DateTime.TryParse(Console.ReadLine(), out DateTime hDate))
        {
            hireDate = hDate;
        }

        var empID =  Generator.GenerateID(fname, lname, hDate);
        var empPass = Generator.GeneratePassword(11);
    }
}
public class Generator
{
    public static int LastSequence { get; private set; } = 1;
    public static string GenerateID(string fname,string lname,DateTime? hireDate)
    {
        // II YY MM DD 01
        if (fname is null)
            throw new InvalidOperationException("fname is null");
        if (lname is null)
            throw new InvalidOperationException("lname is null");
        if (hireDate is null)
        {
            hireDate = DateTime.Now;
        }
        else if(hireDate < DateTime.Now.Date)
        {
            throw new Exception("hireDate < DateTime.Now.Date");
        }
        var yy = hireDate.Value.ToString("YY");
        var mm = hireDate.Value.ToString("MM");
        var dd = hireDate.Value.ToString("DD");

        var code = $"{lname.ToUpper()[0]}{fname.ToUpper()[0]} {yy} {mm} {dd} {LastSequence++}";
        return code;
    }

    public static string GeneratePassword(int length)
    {
        const string ValidScope = "abcdefghijklmnopqrstvwxyzABCDEFGHIJKLMNOPQRSTVWXYZ0123456789";
        Random rnd = new Random();
        string result = "";
        while (0 < length--)
        {
            result += ValidScope[rnd.Next(ValidScope.Length)];
        }
        return result;
    }
}