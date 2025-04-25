class DeliveryService
{
    public static readonly Random random = new Random();

    public void Start(Order order)
    {
        try
        {
            Process(order);
            Ship(order);
            Transmit(order);
            Deliver(order);
        }
        catch(InvalidOperationException ex) // exist exception in .net
        {
            Console.WriteLine($"Service fails due to : {ex.Message}");
            order.status = DeliveryStatus.UNKOWN;
        }
        catch(AccidentException ex) // Custom exception
        {
            Console.WriteLine($"{ex.Message} ,Accident location : {ex.Location}");
            order.status = DeliveryStatus.UNKOWN;
        }
        catch(InvalidAddressException ex) // Custom exception
        {
            Console.WriteLine($"{ex.Message}");
            order.status = DeliveryStatus.UNKOWN;
        }
        catch(GoodsIsDamaged ex) // Ducker exception (Rethrow)
        {
            throw;
        }
        catch (Exception)  // swallow exception
        {

        }
        
    }
    private void Process(Order order)
    {
        FakeIt("Processing");
        if (random.Next(1, 5) == 1)
        {
            throw new InvalidOperationException("Unable to processes the item");
        }
        order.status = DeliveryStatus.PROCESSED;
    }
    private void Ship(Order order)
    {
        FakeIt("Shipping");
        if (random.Next(1, 5) == 1)
        {
            throw new InvalidOperationException("Unable to Shipping the item");
        }
        order.status = DeliveryStatus.SHIPPED;
    }
    private void Transmit(Order order)
    {
        FakeIt("Transmitting");
        if (random.Next(1, 5) == 1)
        {
            throw new AccidentException("34 , Khaled ibn elwaleed , Alexandria ","Transmitting failed due to an Accident !!!!");
        }
        order.status = DeliveryStatus.INTRANSIT;
    }
    private void Deliver(Order order)
    {
        FakeIt("Delivering");
        if(random.Next(1, 5) == 1)
        {
            throw new InvalidAddressException("Couldn't reach the address");
        }
        order.status = DeliveryStatus.DELIVERED;
    }
    private void FakeIt(string title)
    {
        Console.Write(title);
        System.Threading.Thread.Sleep(300);
        Console.Write(".");
        System.Threading.Thread.Sleep(300);
        Console.Write(".");
        System.Threading.Thread.Sleep(300);
        Console.Write(".");
        System.Threading.Thread.Sleep(300);
        Console.Write(".");
        System.Threading.Thread.Sleep(300);
        Console.WriteLine(".");
    }
}

/*
Concept	        Meaning
Thread	        A single path of execution in your app
Threading	    Running multiple threads to do multiple tasks in parallel
Thread.Sleep	Pauses the current thread for a given number of milliseconds
 */