using EmployeeClassSpace;
using MainProgram;
using System;


namespace ReportClassSpace
{
    class Report
    {
        public delegate bool IsIllegableSales(Employee e) ; /* Declaration of the delegate
                                                             * it can be declared in the class or out the class 
                                                             */
        public void ProcessEmployee(Employee[] employees,string title , IsIllegableSales isIllegable)
        {
            Console.WriteLine(title);
            Console.WriteLine("-----------------------------------");
            foreach (var e in employees)
            {
                if (isIllegable(e))
                {
                    Console.WriteLine($"{e.Id,3} | {e.Name,-10} | {e.TotalSales}");
                }
            }
            Console.Write("-----------------------------------");

            Console.WriteLine("\n\n");
        }


    }
}
