class Program
{
    static void Main(string[] args)
    {
        Cashier c1 = new Cashier(new Cash());
        c1.CheckOut(99.99m);
        Cashier c2 = new Cashier(new DebtCard());
        c2.CheckOut(116.34m);
    }
}

class Cashier
{
    private IPayment _payment;
    public Cashier(IPayment payment)
    {
        _payment = payment;
    }
    public void CheckOut(decimal amount)
    {
        _payment.Pay(amount);
    }
}

interface IPayment
{
    public void Pay(decimal amount);
}
class Cash : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Cash Payment : {Math.Round(amount, 2):N0}$");
    }
}
class DebtCard : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Debt Payment : {Math.Round(amount, 2):N0}$");
    }
}

/* Tight Copling means one class is dependant on another class
 * Loose Coupling means one class is dependant on interface rather than class 
 * Here we used Loose Coupling to allow cashier to use any payment tool as i made both Csh and DebtCard use interface IPayment
       and made cashier accept any object has this interface
 */