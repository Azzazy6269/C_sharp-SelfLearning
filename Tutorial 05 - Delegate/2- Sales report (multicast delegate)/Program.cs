using System;
using System.Reflection.Metadata.Ecma335;
using EmployeeClassSpace;

namespace MainProgram
{
    class Program
    {
        public delegate void IsIllegableSales(Employee e);
        public static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee {Id = 1, Name = "Issam", TotalSales = 65000m, Gender = 'M' },
                new Employee {Id = 2, Name = "Youmna", TotalSales = 20000m, Gender = 'F' },
                new Employee {Id = 3, Name = "Kareema", TotalSales = 50000m, Gender = 'F' },
                new Employee {Id = 4, Name = "Mustafa", TotalSales = 150000m, Gender = 'M' },
                new Employee {Id = 5, Name = "Ismail", TotalSales = 0m, Gender = 'M' },
                new Employee {Id = 6, Name = "Omar", TotalSales = 7000m, Gender = 'M' },
                new Employee {Id = 7, Name = "Maram", TotalSales = 40000m, Gender = 'F' },
                new Employee {Id = 8, Name = "Esraa", TotalSales = 90000m, Gender = 'F' },
                new Employee {Id = 9, Name = "Fatma", TotalSales = 6000m, Gender = 'F' },
                new Employee {Id = 10, Name = "Adam", TotalSales = 165000m, Gender = 'M' },
            };

            static void isGreaterThanOrEqual60000(Employee e)
            {
                if (e.TotalSales >= 60000)
                    Console.WriteLine($"{e.Name} acheived more than 60000$ sales");
            }
            static void isBetween60000And20000(Employee e)
            {
                if (e.TotalSales <= 60000 && e.TotalSales >20000)
                    Console.WriteLine($"{e.Name} acheived sales between 20000$ and 60000$");
            }
            static void isLessThan20000(Employee e)
            {
                if (e.TotalSales < 20000 && e.TotalSales !=0)
                    Console.WriteLine($"{e.Name} acheived Less than 20000$ sales");
            }
            static void isMoreThan1_0000_000(Employee e)
            {
                if (e.TotalSales >= 20000)
                    Console.WriteLine($"{e.Name} acheived more than 1 million sales");
            }
            static void isZeroSales(Employee e)
            {
                if (e.TotalSales == 0)
                    Console.WriteLine($"{e.Name} couldn't acheive any sales");
            }

            IsIllegableSales report = isGreaterThanOrEqual60000;
            report += isMoreThan1_0000_000;
            report += isBetween60000And20000;
            report += isLessThan20000;
            report -= isMoreThan1_0000_000;
            report += isZeroSales;

            foreach(var e in emps)
            {
                report(e);
            }



        }
    }
}