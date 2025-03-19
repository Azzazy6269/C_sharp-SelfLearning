class Atm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to ATM! \n" +
                          "1. Deposit \n" +
                          "2. Withdraw \n" +
                          "3. Check Balance \n" +
                          "4. Exit");
        Console.WriteLine("Enter your choice:");
        String choice = Console.ReadLine();
        UInt32 balance = 30000;
        switch (choice)
        {
            case "Deposit" :
                Console.WriteLine("Enter amount to deposit:");
                var deposit = Convert.ToUInt32(Console.ReadLine());
                balance += deposit;
                Console.WriteLine($"Deposit successful! New balance: ${balance}");
                break;
            case "Withdraw" :
                Console.WriteLine("Enter amount to deposit:");
                var Withdraw = Convert.ToUInt32(Console.ReadLine());
                balance -= Withdraw;
                Console.WriteLine($"Withdraw successful! New balance: ${balance}");
                break;
            case "Check Balance":
                Console.WriteLine("Enter amount to deposit:");
                var Check_Balance = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine($"your balance: ${balance}");
                break;
            case "Exit" :
                break;

        }
    }
}