using employee;
class Program
{
    public static void Main(string[] args)
    {
        Employee emp0 = new Employee("Mahmoud Elsayed", 14200, "AI junior developer");
        Employee emp1 = new Employee("Kareem Osama", 8000, "Frontend junior developer");
        Employee emp2 = new Employee("Mostafa Ibraheem", 30000, "Backend senior developer");
        Employee emp3 = new Employee("Ibraheem Adel", 10000, "Database management");
        Employee emp4 = new Employee("Said Elshabrawy", 55000, "team managment");
        Employee emp5 = new Employee("Emad Abdulkader", 18000);

        Console.WriteLine(emp4.showInfo("Said Elshabrawy"));
        Console.WriteLine(emp5.showInfo("Issa osama"));
        Console.WriteLine(emp1.showInfo("Kareem Osama"));


    }
}