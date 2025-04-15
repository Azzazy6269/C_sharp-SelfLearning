class Program
{
    static void Main(string[] args)
    {
        Money m1 = new Money(20);
        Money m2 = new Money(50);

        Money m3 = m1 + m2;
        Money m4 = m2 - m1;
        Money m5 = m1 * 3;
        Money m6 = m2 / 5;
        Money m7 = ++m2;
        bool x = m2 > m1 ; 

        Console.WriteLine($"m3 = {m3.Amount}");
        Console.WriteLine($"m4 = {m4.Amount}");
        Console.WriteLine($"m5 = {m5.Amount}");
        Console.WriteLine($"m6 = {m6.Amount}");
        Console.WriteLine($"m7 = {m7.Amount}");
        Console.WriteLine(x);

        Money m8 = new Money(m1.Amount + m2.Amount); // the same like m3 but without defining operators
        bool y = m4.Amount < m5.Amount; // the same like x but without defiining operators
    }
}


class Money
{
    private decimal amount;
    public decimal Amount => amount;

    public Money(decimal value)
    {
        this.amount = Math.Round(value,2);
    }

    /* operators you can define : + , - , * , / , % , ^ , & , | , ++ , --
     * operators in pairs : (< , >) , (<= , >=) , (== , !=)  each pair must be declared together . you can't declare one without the another
     */

    public static Money operator +(Money money1, Money money2)
    {
        return new Money(money1.Amount + money2.Amount);
    }
    public static Money operator -(Money money1, Money money2) => new Money(money1.Amount - money2.Amount);
    public static Money operator *(Money money1, decimal Multiply_Factor) => new Money(money1.Amount * Multiply_Factor);
    public static Money operator /(Money money , decimal Dividing_Factor) => new Money(money.Amount / Dividing_Factor);
    public static bool operator  <(Money money1, Money money2) => money1.Amount < money2.Amount;
    public static bool operator  >(Money money1, Money money2) => money1.Amount > money2.Amount;
    public static bool operator  <=(Money money1, Money money2) => money1.Amount <= money2.Amount;
    public static bool operator  >=(Money money1, Money money2) => money1.Amount >= money2.Amount;
    public static bool operator  ==(Money money1, Money money2) => money1.Amount <= money2.Amount;
    public static bool operator  !=(Money money1, Money money2) => money1.Amount >= money2.Amount;
    public static Money operator ++(Money money) => new Money(money.Amount+1);
    public static Money operator --(Money money) => new Money(money.Amount-1);



}