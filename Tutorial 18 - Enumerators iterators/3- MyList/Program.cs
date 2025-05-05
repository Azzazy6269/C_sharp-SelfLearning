class Progarm
{
    static void Main(string[] args)
    {
        string[] arr = new[] {"xcf","jk;","hhg","asds","wef","jyv","ytb" };
        var list1 = new MyList<string>(arr);
        list1[1] = "swqp";
        foreach(var i in list1)
        {
            Console.WriteLine(i);
        }
    }
}
