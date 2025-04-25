class Program
{
    static void Main(string[] args)
    {
        try
        {
            Account a1 = new Account("Nada645", "123456", "Nada@gmail.com", 23);
            a1.login();
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
