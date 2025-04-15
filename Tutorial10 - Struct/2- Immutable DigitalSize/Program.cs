class Program
{
    static void Main(string[] args)
    {
        DigitalSize d1 = new DigitalSize(60000);
        DigitalSize d2 = d1.AddMB(130);// You have to store the value returned from the method in an object of DigitalSize  
        d1 = d1.AddBit(8); /* You stored the returned value in DigitalSize object which was the original object . but how?
                              - d1 was a reference to data of it's object in stack .
                              - you created new object from dataType DigitalSize .
                              - you assigned(referenced) to the new object by d1 
                              - the old object still there in stack but there's no reference to it so it will be deleted by clr or somehow
                            */
        Console.WriteLine(d1.Bit);
        Console.WriteLine(d2.Bit);

    }
}

struct DigitalSize
{
    private long bits = 12;
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


    /* mutable means that you can change the values of the object when you want 
     * immutable means that you can't never change the values after you gave them their intialize values while creating the object
     * i wrote the rest of the code in this way to explain the immutable concept
     * as if you tried to add some bits to the old object it will return it in a new object which means you can't modify the data of the object*/
    public DigitalSize AddBit(long bit) => Add(bit, bitsInBit);
    
    public DigitalSize AddByte(long bit) => Add(bit, bitsInByte);
    
    public DigitalSize AddKB(long bit) => Add(bit, bitsInKB);
   
    public DigitalSize AddMB(long bit) => Add(bit, bitsInMB);
    
    public DigitalSize AddGB(long bit) => Add(bit, bitsInGB);
   
    public DigitalSize AddTB(long bit) => Add(bit, bitsInTB);
    
    private DigitalSize Add(long value,long scale)
    {
        return new DigitalSize(bits + (value * scale));
    }

}