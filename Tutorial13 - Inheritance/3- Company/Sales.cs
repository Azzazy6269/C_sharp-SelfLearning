using Employee_space;
namespace Sales_space
{
    class Sales : Employee
    {
        public Sales(int id, string name, decimal loggedHours, decimal wage, decimal SalesVolume, decimal Commision) : base(id, name, loggedHours, wage)
        {
            this.SalesVolume = SalesVolume;
            this.Commision = Commision;
        }
        private decimal SalesVolume { get; set; }
        private decimal Commision { get; set; }
        private decimal CalculateBonus()
        {
            return SalesVolume * Commision;
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
