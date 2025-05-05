using System;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Age[] ages = new Age[10];
        for (int i=0; i < ages.Length; i++)
        {
            ages[i] = new (random.Next(0, 80));
        }
        Array.Sort(ages);
        for (int i=0;i<ages.Length ; i++)
            Console.WriteLine(ages[i].age);
    }
}

class Age : IComparable
{
    private int _age;
    public int age => _age;
    public Age(int age)
    {
        _age = age;
    }

    public int CompareTo(object? obj)
    {
        if (obj is null)
            throw new InvalidOperationException("it's null object !!!!");
        var objAge = obj as Age;
        if (objAge is null)
            throw new InvalidCastException("it isn't Age object");
        return this._age.CompareTo(objAge._age);
    }
}