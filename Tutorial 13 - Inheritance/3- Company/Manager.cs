using Employee_space;
namespace Manager_space
{
    class Manager : Employee
    {
        public Manager(int id, string name, decimal loggedHours, decimal wage) : base(id,name,loggedHours,wage)
        {
            
        }
        private const decimal Allowance = 0.05m;
        private decimal CalculateAllowance()
        {
            return Allowance * base.CalculateSalary();
        }
        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + CalculateAllowance();
        }
        public override string ToString()
        {
            return base.ToString()+
                $"Allowance = {CalculateAllowance()} $\n" +
                $"Net salary = {CalculateSalary()} $";
        }
    }


}
