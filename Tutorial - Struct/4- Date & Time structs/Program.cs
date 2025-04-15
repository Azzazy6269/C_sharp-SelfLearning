class Program
{
    static void Main(string[] args)
    {
        DateTime date = new DateTime(1999, 11, 2);
        date = date.AddMonths(2); //DateTime is a readonly struct so i can't modify it's value and i have to store the new values in new object like i did in DigitalSize project
        Console.WriteLine(date.Year);

        /*at the end
          You have to know that most datatypes are readonly structs 
         */
        int x = 5;
        x =  x + 1; 
        /*string is a class */
        string y = "Hello";
        y = "Hello there"; // string is a class so it's reference type which means y is in stack but reference to its data in heap
                           // so you refrenced to the new data by the same y
                           // the old data is still there in heap but with no variable in stack reference to it so the garbage collector will delete it 
    }
}
