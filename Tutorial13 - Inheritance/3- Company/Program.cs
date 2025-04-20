using Employee_space;
using Manager_space;
using Developer_space;
using Maintance_space;
using Sales_space;
class Program
{
    static void Main(string[] args)
    {
        Manager m = new Manager(250, "Saad eltarabeshy", 180, 10);

        Maintance ms = new Maintance(711, "Salim Ibraheem", 182, 8);

        Sales s = new Sales(133, "Maram Elsayed", 176, 9, 10000, 0.05m);

        Developer d = new Developer(1003, "Asmaa Issam", 186, 15, true);
        

        Employee[] emps = { m, ms, s, d };
        foreach (var i in emps)
        {
            Console.WriteLine(i.ToString());
        }


        
    }
}
