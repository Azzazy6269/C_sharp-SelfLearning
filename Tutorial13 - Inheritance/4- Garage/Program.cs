class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car(1, "Civic", "Honda", 20m, 50m, false, true, 4);
        Motorcycle moto1 = new Motorcycle(2, "R15", "Yamaha", 10m, 20m, true, true);
        Truck truck1 = new Truck(3, "Actros", "Mercedes", 80m, 150m, true, 18m);

        Console.WriteLine(car1.ToString());
        Console.WriteLine(moto1.ToString());
        Console.WriteLine(truck1.ToString());

    }
}
