class Account
{
    public string userName { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    public int age { get; set; }
    public Account(string userName, string password, string email, int age)
    {
        this.userName = userName;
        this.password = password;
        this.email = email;
        if (age < 18)
        {
            throw new InvalidDataException("You must be older than 18");
        }
        else
        {
            this.age = age;
        }
    }
    public void login()
    {
        int trialNum = 1;
        while(true)
        {
            Console.WriteLine("Enter username");
            string user = Console.ReadLine();
            Console.WriteLine("Enter password");
            string pass =  Console.ReadLine();

            if ((user==this.userName) &&(pass == this.password))
            {
                Console.WriteLine("Successful login");
                break;
            }else if(trialNum == 3)
            {
                throw new Hacking_trialException("Hacking trial ", this);
            }
            else
            {
                trialNum++;
                Console.WriteLine("Wrong data !!! Try again");
            }
        }
    }

}
