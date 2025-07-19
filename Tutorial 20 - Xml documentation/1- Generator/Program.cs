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
/// <summary>
/// The main Generator class
/// <remark>
/// this class can generate employee IDs and random passwords
/// </remark>
/// </summary>
public class Generator
{
    /// <value>Value of the last sequence ID </value>
    public static int LastSequence { get; private set; } = 1;

    /// <summary>
    /// Generate employee id by processing <paramref name="fname"/> , <paramref name="lname"/> , <paramref name="hireDate"/> 
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    /// <item> <description> II : ID initials with first letter of <paramref name="fname"/> and <paramref name="lname"/>  </description> </item>
    /// <item> <description> YY : then 2 digits of year from <paramref name="hireDate"/> </description> </item>
    /// <item> <description> MM : then 2 digits of Month from <paramref name="hireDate"/> </description> </item>
    /// <item> <description> DD : then 2 digits of Day from <paramref name="hireDate"/> </description> </item>
    /// <item> <description> 01 : then LastSequence+1 <paramref name="hireDate"/> </description> </item>
    /// </list>
    /// </remarks>
    /// <param name="fname"></param>
    /// <param name="lname"></param>
    /// <param name="hireDate"></param>
    /// <example>
    /// <code>
    /// var MohsenID =  Generator.GenerateID("Mohsen", "Khaleel", new DateTime(2025,6,1,0,0,0));
    /// Console.WriteLine(MohsenID);
    /// </code>
    /// </example>
    /// <returns>
    /// employee ID as a string
    /// </returns>
    /// <exception cref="InvalidOperationException"> Thrown when <paramref name="fname"/> or <paramref name="lname"/> is null </exception>
    /// <exception cref="Exception"> Thrown when <paramref name="hireDate"/> is less than DateTime.Now.Date </exception>
    /// See <see cref="GeneratePassword(int)"/> to generate random password
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

        var code = $"{lname.ToUpper()[0]}{fname.ToUpper()[0]} {yy} {mm} {dd} {(LastSequence++).ToString().PadLeft(2,'0')}";
        return code;
    }
    /// <summary>
    /// Generate random password 
    /// </summary>
    /// <param name="length"></param>
    /// <returns></returns>
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