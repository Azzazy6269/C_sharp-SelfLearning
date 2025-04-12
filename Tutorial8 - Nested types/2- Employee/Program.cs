class Program
{
    static  void Main()
    {
        Employee e1 = new Employee(1,"Osama",254,"LifeQuality",7,"Backend development",18000,1200);
        Console.WriteLine(e1.salary.Total_Salary);
        
    }
}

class Employee
{
    public Employee(int id ,string name,int insuranceId ,string insuranceCompany,
                    int departmentId ,string DepartmentName ,int baseSalary,int salaryBonus)
    {
        this.Id = id;
        this.Name = name;
        this.insurance.Policy_Id = insuranceId;
        this.insurance.CompanyName = insuranceCompany;
        this.department.DepartmentId = departmentId;
        this.department.DepartmentName = DepartmentName;
        this.salary.Base_Salary = baseSalary;
        this.salary.Bonus = salaryBonus;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public Insurance insurance = new Insurance { Policy_Id = 0, CompanyName = "Non" };
    public Department department = new Department { DepartmentId = 0, DepartmentName = "Non" };
    public Salary salary = new Salary { Base_Salary = 0, Bonus = 0 };
    public class Insurance
    {
        public int Policy_Id { get; set; }
        public string CompanyName { get; set; }

    }
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
    public class Salary
    {
        public int Base_Salary { get; set; }
        public int Bonus { get; set; }
        public int Total_Salary{get => Base_Salary + Bonus;}
    }
}