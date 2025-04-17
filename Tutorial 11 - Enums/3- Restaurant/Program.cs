class Program
{
    static void Main(string[] args)
    {
        ShowMenu();
        Order d1 = new Order("Reem", 12, Menu.Chicken_Ranch | Menu.Four_Cheese | Menu.Fries_medium | Menu.Cola);
        d1.PrintReceipt();
    }
    public static void ShowMenu()
    {
        foreach(var flavour in Enum.GetNames(typeof(Menu)))
        {
            Console.WriteLine(flavour);
        }
        Console.WriteLine("--------------\n");

    }
}

[Flags]
public enum Menu : int // 0b_0000_0000_0000_0000_0000_0000_0000_0000
{
    Pepperoni = 1 << 0,   
    BBQ_Chicken = 1 << 1,   
    Four_Cheese = 1 << 2,   
    Veggie = 1 << 3,   
    Meat_Lovers = 1 << 4,   
    Supreme = 1 << 5,   
    Buffalo_Chicken = 1 << 6,   
    Mushroom_Lovers = 1 << 7,   
    Margherita = 1 << 8,   
    Tuna = 1 << 9,   
    Chicken_Ranch = 1 << 10,  
    Spicy_Beef = 1 << 11,  
    Sausage_Delight = 1 << 12,  
    Mediterranean = 1 << 13,  
    Hot_N_Spicy = 1 << 14,

    Fries_medium = 1 << 15,
    Fries_Large = 1 << 16,
    
    Cola = 1 << 17,
    Sprite = 1 << 18,
    Fanta = 1 << 19,
}
class Order
{
    private string _clientName;
    private int _orderID;
    private Menu _order;
    private TimeOnly _time;
    public Order(string clientName, int orderID,Menu order)
    {
        _clientName = clientName;
        _orderID = orderID;
        _order = order;
        _time = TimeOnly.FromDateTime(DateTime.Now);

    }
    public void PrintReceipt()
    {
        Console.WriteLine($"Order num : {_orderID}\n" +
                          $"Client Name : {_clientName}\n" +
                          $"Time : {_time}\n" +
                          $"Order :{_order}\n" +
                          $"Order will be ready by {TimeOnly.FromDateTime(DateTime.Now.AddMinutes(45))}");
    }


}