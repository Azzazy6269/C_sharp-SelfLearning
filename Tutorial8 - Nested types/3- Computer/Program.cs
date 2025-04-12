class Progarm
{
    static void Main(string[] args)
    {
        Computer c1 = new Computer("core i7", 12000, "semiens 32Giga", 9500, "Nividia 4Giga", 3000);
        Console.WriteLine(c1.price);
    }
}

class Computer
{
    public uint price { get; set; }
    CPU cpu = new CPU();
    RAM ram = new RAM();
    GPU gpu = new GPU();

    public Computer(string cpu_type,uint cpu_price, string ram_type, uint ram_price,string gpu_type, uint gpu_price)
    {
        this.cpu.type = cpu_type;
        this.cpu.price = cpu_price;
        this.ram.type = ram_type;
        this.ram.price = ram_price;
        this.gpu.type = gpu_type;
        this.gpu.price = gpu_price;
        price = calculate_price();
    }
    class CPU
    {
        public string type { get; set; }
        public uint price { get; set; }
    }
    class RAM
    {
        public string type { get; set; }
        public uint price { get; set; }
    }
    class GPU
    {
        public string type { get; set; }
        public uint price { get; set; }
    }

    private uint calculate_price()
    {
        return cpu.price + ram.price + gpu.price;
    }
}