using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[]args)
    {
        Pizza z1 = new Pizza();
        z1.AddDough("extra dough");
        z1.AddCheese(true);
        z1.AddOlives(true);/* you can't apply overriding in extension methods
                            * there is two methods called AddOlives one in Pizza class and one in PizzaExtension class
                            * the method from Pizza class will be called not the method in PizzaExtension
                            */
        Console.WriteLine(z1);
    }
}

class Pizza
{
    public string content { get; set; }
    public decimal totalPrice { get; set; }
    public Pizza()
    {
        totalPrice = 10m;
    }
    public void AddOlives( bool extra)
    {
        content += $" olive xfree";
        totalPrice += 0m;

    }
    public override string ToString()
    {
        return $"{content}\nTotal price = {totalPrice}";
    }
 }

static class PizzaExtension
{
    public static Pizza AddDough(this Pizza value,string type)
    {
        value.content += $" {type} Dough x4$";
        value.totalPrice += 4m;
        return value;
    }
    public static Pizza AddSauce(this Pizza value, string type)
    {
        value.content += $" Tomato Sauce x2$";
        value.totalPrice += 2m;
        return value;
    }
    public static Pizza AddCheese(this Pizza value, bool extra)
    {
        value.content += $" cheese x2$";
        value.totalPrice += 2m;
        return value;
    }
    public static Pizza AddOlives(this Pizza value, bool extra)
    {
        value.content += $" olive x2$";
        value.totalPrice += 2m;
        return value;
    }
}
