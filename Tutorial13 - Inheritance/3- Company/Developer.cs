using Employee_space;
namespace Developer_space
{
    class Developer : Employee
    {
        public Developer(int id, string name, decimal loggedHours, decimal wage, bool TaskCompleted) : base(id, name, loggedHours, wage)
        {
            this.TaskCompleted = TaskCompleted;
        }
        private const decimal commision = 0.03m;
        private bool TaskCompleted { get; set; }
        private decimal CalculateBonus()
        {
            if(TaskCompleted) return commision * base.CalculateSalary();
            return 0;
        }
        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + CalculateBonus();
        }
        public override string ToString()
        {
            return base.ToString() +
                $"Bonus = {CalculateBonus()} $\n" +
                $"Net salary = {CalculateSalary()} $";
        }
    }


}
