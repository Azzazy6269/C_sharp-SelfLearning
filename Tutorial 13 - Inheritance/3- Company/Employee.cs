using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_space
{
    abstract class Employee
    {
        private const int MinimumLoggedHours = 176;
        private const decimal OverTimeRate = 1.25m;

        protected Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; } // salaryPerHour

        protected virtual decimal CalculateSalary()
        {
            return CalculateBaseSalary() + CalculateOverTime();
        }
        protected decimal CalculateBaseSalary()
        {
            return (MinimumLoggedHours * Wage);
        }
        protected decimal CalculateOverTime()
        {
            var AdditionalHours = LoggedHours > MinimumLoggedHours ? (LoggedHours - MinimumLoggedHours) : 0;
            return (AdditionalHours * Wage * OverTimeRate);
        }
        public override string ToString()
        {
            
            
            return $"\nPosition : {position()}\n" +
                   $"Id : {Id}\n" +
                   $"Name : {Name}\n" +
                   $"Logged hours {LoggedHours} hours\n" +
                   $"Wage : {Wage} $/hour\n" +
                   $"Base salary : {CalculateBaseSalary()} $\n" +
                   $"Over time : {CalculateOverTime()} $\n";
        }
        private string position()
        {
            var type = GetType().ToString();
            if (type == "Manager_space.Manager") return "Manager";
            if (type == "Maintance_space.Maintance") return "Maintance";
            if (type == "Sales_space.Sales") return "Sales";
            if (type == "Developer_space.Developer") return "Developer";
            return "";

        }
    }


}
