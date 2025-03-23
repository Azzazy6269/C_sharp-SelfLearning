class Program
{
    static void Main(string[] args)
    {
        IP ip1 = new IP(192, 168, 1, 1);
        Console.WriteLine(ip1.Address);
        Console.WriteLine(ip1[0]);
        ip1[2] = 32;
        Console.WriteLine(ip1.Address);
        IP ip2 = new IP("192.168.16.32");
        Console.WriteLine(ip2.Address);
        Console.WriteLine(ip2[2]);

        //string x = "192.162.12.5";
        //string[] y =  x.Split('.');

    }
}

public class IP // MAX IP : 255.255.255.255
{
    private int[] segments = new int[4];

    public int this[int index]
    {
        get
        {
            return segments[index];
        }
        set
        {
            segments[index] = value;           
        }
    }
    public IP(int segment1, int segment2, int segment3, int segment4)
    {
        segments[0] = segment1;
        segments[1] = segment2;
        segments[2] = segment3;
        segments[3] = segment4;
    }
    public IP(string IPAddress)
    {
        var segs = IPAddress.Split('.');
        for (int i =0; i< segs.Length; i++)
        {
            segments[i] = Convert.ToInt32(segs[i]);
            
        }
    }

    public string Address => string.Join('.', segments);
}