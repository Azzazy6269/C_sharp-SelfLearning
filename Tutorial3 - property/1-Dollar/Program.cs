class Program
{
    static void Main(string[] args)
    {
        Dollar dollar = new Dollar(1.99m);
        //  dollar.Amount = 2;  //set
        dollar.setAmount(2); // private set
        decimal x = dollar.Amount;  //get
    }
}



public class Dollar
{
    private decimal _amount;
   
    public decimal Amount
    {
        get
        {
            return _amount;
        }
        private set
        {
            this._amount=processValue(value);
        }
    }
    public void setAmount(decimal amount)
    {
        Amount = amount;
    }
    public Dollar(decimal amount)
    {
        this._amount = processValue(amount);

    }

    private decimal processValue(decimal value) => value <= 0 ? 0 : Math.Round(value, 2);
}