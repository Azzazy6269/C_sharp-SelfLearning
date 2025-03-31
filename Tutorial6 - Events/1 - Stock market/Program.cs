class Program
{
    public static void Main(string[] args)
    {
        Stock s1 = new Stock("ElMokaweloon Elararb",2.66m);
        s1.OnPriceChanged += StockPriceHasChanged; // Subscribe the event -> which means to connect a method to the event to be called when the event is published
        s1.ChangeStockPriceBy(.56m); 
        s1.ChangeStockPriceBy(-.06m);
        s1.OnPriceChanged -= StockPriceHasChanged; // UnSubscribe the event
        s1.ChangeStockPriceBy(-.56m);
        s1.ChangeStockPriceBy(+.06m);
        s1.OnPriceChanged += (Stock stock, decimal oldPrice) => {   /*Subscribe using Lambda expression 
                                                                     *You can't never UnSubscribe the lambda expression
                                                                     */
            if (stock.Price > oldPrice)
            {
                Console.WriteLine($"{stock.Name} price has raised ");
            }
            if (stock.Price < oldPrice)
            {
                Console.WriteLine($"{stock.Name} price has reduced ");
            }
        };
        s1.ChangeStockPriceBy(.56m);
        s1.ChangeStockPriceBy(-.06m);
    }

    private static void StockPriceHasChanged(Stock stock, decimal oldPrice)
    {
        if (stock.Price > oldPrice)
        {
            Console.WriteLine($"{stock.Name} price has raised ");
        }
        if (stock.Price < oldPrice)
        {
            Console.WriteLine($"{stock.Name} price has reduced ");
        }
    }
}
//declaring delegate for the event
public delegate void StockPriceChangeHandler(Stock stock ,decimal oldPrice );
public class Stock
{

    private string _name;
    private decimal _price;

    //declaring the event as a variable of dataType of delegateName
    public event StockPriceChangeHandler OnPriceChanged;

    public string Name => this._name;
    public decimal Price { get => this._price; set => this._price = value; }
    public Stock(string name)
    {
        this._name = name;
    }
    public Stock(string name , decimal price)
    {
        this._name = name;
        Price = price;
    }
    public void ChangeStockPriceBy(decimal percent)
    {
        decimal oldPrice = this.Price;
        Price += Math.Round(Price * percent,2);
        if (OnPriceChanged != null)  //make sure there's subscriber
        {
            OnPriceChanged(this, oldPrice); // firing the event or publishing the event
        }
    } 
}