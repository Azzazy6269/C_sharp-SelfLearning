using System;
using System.Reflection.Metadata.Ecma335;
using EmployeeClassSpace;
using ReportClassSpace;
using static ReportClassSpace.Report;

namespace MainProgram
{
    public class Program
    {
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

            Report r1 = new Report();
            // methods that will be used instead of the delegateion
            static bool isGreaterThanOrEqual60000(Employee e) => e.TotalSales >= 60000m; // Normal method
            static bool isBetween60000And20000(Employee e) => e.TotalSales < 60000m && e.TotalSales >= 20000m; // Normal method
            static bool isLessThan20000(Employee e) => e.TotalSales < 20000m;// Normal method
            static bool isGreaterThanOneMillion(Employee e) // Normal method
            {
                return (e.TotalSales >= 1_000_000m);
            }

            /*Assigning the methods to a variable of the delegate type
            *I assigned here to the variables x,y,z and to the variable isIllegable which was declared as a parameter for ProcessEmployee method
            */
            IsIllegableSales x = isGreaterThanOrEqual60000;
            if (x(emps[3])) Console.WriteLine($"{emps[3].Name}'s sales is greater than 60000$ ");
            var y = delegate (Employee e) { return e.TotalSales != 0; };     //Anonymous delegate , one time delegate
            if (y(emps[7])) Console.WriteLine($"{emps[7].Name} isn't zero sales this month");
            var z = (Employee e) => e.TotalSales >= 20000; //Lambda expression for delegate
            if (z(emps[9])) Console.WriteLine($"{emps[9].Name} could acheive the target this month\n");

            r1.ProcessEmployee(emps, "Employees with sales >= 60,000$", isGreaterThanOrEqual60000);
            r1.ProcessEmployee(emps, "Employees with 20,000$ <= sales < 60,000$", isBetween60000And20000);
            r1.ProcessEmployee(emps, "Employees with sales < 20,000$", isLessThan20000);
            r1.ProcessEmployee(emps, "Employees with no sales", delegate (Employee e) { return e.TotalSales == 0; }); //Anonymous delegate
            r1.ProcessEmployee(emps, $"Emplyees who could acheive the monthly target",  e => e.TotalSales >= 20000); /*lambda expression for delegate
                                                                                                                      *I wrote e=>e.TotalSales without writing Employee before e because it was written in the parameters
                                                                                                                      */

                                                                                                                       
            
            
        }
    }
}

