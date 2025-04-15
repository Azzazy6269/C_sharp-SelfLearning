class Program
{
    static void Main(string[] args)
    {
        DigitalSize d1 = new DigitalSize(60000);
        d1.bits = 20000;
        d1.AddKB(10);
        Console.WriteLine(d1.KB);
        Console.WriteLine(d1.Bit);

    }
}

struct DigitalSize
{
    public long bits = 12;
    public string Bit => $"{(bits / bitsInBit):N0} Bits";
    public string Byte => $"{(bits / bitsInByte):N0} Bytes";
    public string KB => $"{(bits / bitsInKB):N0} KB";
    public string MB => $"{(bits / bitsInMB):N0} MB";
    public string GB => $"{(bits / bitsInGB):N0} GB";
    public string TB => $"{(bits / bitsInTB):N0} TB";

    private const long bitsInBit = 1; // you can intialize constants unlike the fields as it's the only way you can intialize constansts 
    private const long bitsInByte = bitsInBit * 8;
    private const long bitsInKB = bitsInByte * 1024;
    private const long bitsInMB = bitsInKB * 1024;
    private const long bitsInGB = bitsInMB * 1024;
    private const long bitsInTB = bitsInGB * 1024;

    public DigitalSize(long initialvalue)
    {
        this.bits = initialvalue;
    }

    public void AddBits(long bits)
    {
        this.bits = this.bits + bits; 
    }
    public void AddKB(long kb)
    {
        this.bits = bits + (bitsInKB * kb);
    }
    public void AddMB(long mb)
    {
        this.bits = bits + (bitsInMB * mb);
    }
    public void AddGB(long gb)
    {
        this.bits = bits + (bitsInGB * gb);
    }
    public void AddTB(long tb)
    {
        this.bits = bits + (bitsInTB * tb);
    }
}
