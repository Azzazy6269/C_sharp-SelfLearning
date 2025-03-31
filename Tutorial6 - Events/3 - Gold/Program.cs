class Program
{
    public static void Main(string[] args)
    {
        Gold g1 = new Gold("21k gold", 4500);
        g1.PriceChangedHandler += PriceChangeMethod;
        g1.PriceChange(100);
        g1.PriceChange(-350);
        g1.PriceChange(500);
    }

    public static void PriceChangeMethod(Gold g)
    {
        Console.WriteLine($"{g.type} price become {g.price}");
    }
}

public class Gold
{
    private string _type;
    private short _price;

    public string type { get => _type; }
    public short price { get => _price;}

    public Gold(string type, short price)
    {
        this._type = type;
        this._price = price;
    }

    public delegate void OnPriceChangeHandler(Gold g);
    public event OnPriceChangeHandler PriceChangedHandler;

    public void PriceChange(short newPrice)
    {
        short oldPrice = this.price;
        _price += newPrice;
        if (PriceChangedHandler != null)  //make sure there's subscriber
        {
            PriceChangedHandler(this); // publishing the event
        }
    }

}