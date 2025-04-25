using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var order = new Order { id = 711, CustomerName = "Essam", Address = "Alzqaziq , Farouk st", status = DeliveryStatus.INTRANSIT };
        var service = new DeliveryService();
        try
        {
            service.Start(order);
        }catch (GoodsIsDamaged)
        {
            Console.WriteLine("Goods got damaged");
        }

        Console.WriteLine(order.ToString());
        Console.ReadKey();
    }
}
