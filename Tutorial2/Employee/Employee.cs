using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee;

class Employee
{
    private const double TAX = 0.12;
    private string name;
    private int salary;
    private string position;
    private double netSalary;

    public Employee(string name , int salary , string position)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.netSalary = netSalaryCalc(this.salary);
    }
    public Employee(string name, int salary) : this(name , salary , "General software developer")
    {

    }

    private double netSalaryCalc(int salary)
    {
        return (double)salary*(1-TAX);
    }
    public string showInfo(string name )
    {
        if (name == this.name)
        {
            return $"name : {this.name}\n" +
                   $"net salary : {netSalary}\n" +
                   $"position : {position} \n";
        }else
        {
            return "Wrong information\n";
        }
    }
    
}
