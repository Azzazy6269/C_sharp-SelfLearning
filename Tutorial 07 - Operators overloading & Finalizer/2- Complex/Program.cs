class Program
{
    static void Main(string[] args)
    {
        ComplexNumber c1 = new ComplexNumber(16.5, 144);
        ComplexNumber c2 = new ComplexNumber(.22, 51.44);

        ComplexNumber c3 = c1 + c2;
        Console.WriteLine(c3.complex);
        Console.WriteLine(c3.real);
        Console.WriteLine(c3.imaginary);

        ComplexNumber c4 = c1 * c2;
        Console.WriteLine(c4.complex);
        Console.WriteLine(c4.real);
        Console.WriteLine(c4.imaginary);
    }
}

class ComplexNumber
{
    public double real { get; set; }
    public double imaginary { get; set; }
    public string complex { get; set; }
    public ComplexNumber(double real , double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
        this.complex = $"{real.ToString()} + {imaginary.ToString()}i";
    }
    
    public static ComplexNumber operator +(ComplexNumber complex1, ComplexNumber complex2)
    {
        return new ComplexNumber(complex1.real+complex2.real,complex1.imaginary+complex2.imaginary); 
    }
    public static ComplexNumber operator -(ComplexNumber complex1, ComplexNumber complex2)
    {
        return new ComplexNumber(complex1.real - complex2.real, complex1.imaginary - complex2.imaginary);
    }
    public static ComplexNumber operator *(ComplexNumber complex1, ComplexNumber complex2)
    {
        return new ComplexNumber((complex1.real*complex2.real)-(complex1.imaginary* complex2.imaginary),
                                    (complex1.real*complex2.imaginary)+(complex2.real * complex1.imaginary));
    }
}

