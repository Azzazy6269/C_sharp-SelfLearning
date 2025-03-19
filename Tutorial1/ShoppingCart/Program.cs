class Cart
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of items: ");
        var numItems = Convert.ToUInt16(Console.ReadLine());
        ushort [] Items = new ushort[numItems];
        var total = 0;
        for (UInt16 i =0; i < numItems; i++)
        {
            Console.WriteLine($"Enter price of item {i+1} : ");
            Items[i] = Convert.ToUInt16(Console.ReadLine());
            total += Items[i];
        }
        var discount = total * 0.1;
        var FinalCost = total - discount;
        var Avg_Item_Pice = FinalCost / numItems;

        Console.Write($"Total cost before discount: ${total}\n" +
                      $"Discount applied: ${discount}\n" +
                      $"Final cost: ${FinalCost}\n" +
                      $"Average price per item: ${Avg_Item_Pice}");
    }
}