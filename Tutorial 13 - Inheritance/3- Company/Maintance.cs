using Employee_space;
namespace Maintance_space
{
    class Maintance : Employee
    {
        public Maintance(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {

        }
        private const decimal Hardship = 100m;
        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + Hardship;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"Hardship = {Hardship} $\n" +
                $"Net salary = {CalculateSalary()} $";
        }
    }


}
