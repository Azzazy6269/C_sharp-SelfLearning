class Hacking_trialException : Exception
{
    public Hacking_trialException(string message , Account acc) : base(message)
    {
        Console.WriteLine($"a message will be sent to {acc.email} to report him about hacking trial");
    }
}