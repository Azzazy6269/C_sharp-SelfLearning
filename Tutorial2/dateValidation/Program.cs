using System.Runtime.CompilerServices;

class program
{
    static void Main(string[] args)
    {
        Date d1 = new Date(22,11,1999);
        Console.WriteLine(d1.GetDate());
    }
}


public class Date
{
    private static readonly int[] DayToMonth365 = { 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
    private static readonly int[] DayToMonth366 = { 31, 29, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };

    private readonly int day = 01;
    private readonly int month = 01;
    private readonly int year = 01;

    public Date(int day, int month, int year)
    {
        bool isLeep = ((year % 4 == 0) && (year % 100 != 0  ||  year % 400 ==0));
        if (year >=1 && year <= 9999 && month >0 && month <=12 )
        {
            int[] days = isLeep ? DayToMonth366 : DayToMonth365;
            if(day > 0 && day < days[month - 1])
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
        }

        
    }
    public Date(int month, int year) : this(1, month, year)
    {

    }
    public Date(int year) : this(1, 1, year)
    {

    }
    public static Date create(int day, int month, int year)
    {
        return new Date(day,month, year);
    }
    public string GetDate()
    {
        return $"{this.day.ToString().PadLeft(2, '0')}/{this.month.ToString().PadLeft(2, '0')}/{this.year.ToString().PadLeft(4, '0')}";
    }
}