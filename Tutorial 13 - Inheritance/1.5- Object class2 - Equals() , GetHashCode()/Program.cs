class Progarm
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee { id = 12, name = "Issam A", salary = 18000m, department = "IT" };
        Employee e2 = new Employee { id = 12, name = "Issam A", salary = 18000m, department = "IT" };
        Console.WriteLine(e1.Equals(e2)); 
        Console.WriteLine(e1 == e2);
        Console.WriteLine(e1.GetHashCode());
        Console.WriteLine(e2.GetHashCode());
    }
}

class Employee
{
    public int id { get; set; }
    public string name { get; set; }
    public decimal salary { get; set; }
    public string department { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is Employee))
            return false;
        var emp = obj as Employee;

        return (this.id == emp.id && this.name == emp.name && this.department == emp.department && this.salary == emp.salary);
    }

    public override int GetHashCode()
    {
        int hash = 13; // write any prime number
        hash = (hash * 7) + id.GetHashCode(); // id is int so it's HashCode will be it's value
        hash = (hash * 7) + name.GetHashCode(); // each string has HashCode at runtime
        hash = (hash * 7) + salary.GetHashCode(); // each decimal has HashCode at runtime
        hash = (hash * 7) + department.GetHashCode(); // each string has HashCode at runtime

        return hash;
    }
    /*
     If e1.Equals(e2) returns true, then e1.GetHashCode() must return the same value as e2.GetHashCode().
     But the reverse is not required — two objects can have the same hash code even if they are not equal (called a hash collision).
     when you override Equals(), you should override GetHashCode()
     */
    public static bool operator ==(Employee lhs, Employee rhs) => lhs.Equals(rhs);
    public static bool operator !=(Employee lhs, Employee rhs) => !(lhs.Equals(rhs));
}