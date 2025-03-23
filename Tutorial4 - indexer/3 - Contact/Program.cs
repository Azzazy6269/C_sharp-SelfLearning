class Program
{
    static void Main(string[] args)
    {
        string[] PhoneNumbers = new string[] { "01092641615", "01123856269", "01545236795", "01235412698" };
        string[] Names = new string[] { "Ibraheem", "Mohammed","Osama","Yasseen"};
        Contacts c1 = new Contacts(PhoneNumbers, Names);
        c1.AddContact("Mona", "01235164801");
        Console.WriteLine(c1[1]);
        Console.WriteLine(c1["01123856269"]);
        Console.WriteLine(c1["Ibraheem"]);

        Console.WriteLine(c1[4]);
        Console.WriteLine(c1["01235164801"]);
        Console.WriteLine(c1["Mona"]);

    }
}

public class Contacts
{
    private string[] _phoneNumbers = new string[50];
    private string[] _names = new string[50];

    public Contacts(string[] phoneNumbers, string[] names)
    {
        Array.Copy(phoneNumbers, _phoneNumbers, phoneNumbers.Length);
        Array.Copy(names, _names, names.Length);       
    }
    public string this[int phoneIndex]
    {
        get
        {
            return _names[phoneIndex];
        }
        set
        {
            _names[phoneIndex] = value;
        }
    }
    public string this[string name_Or_number]
    {
        get
        {
            if (name_Or_number.StartsWith('0'))
            {
                for (int i = 0; i < _phoneNumbers.Length; i++)
                {
                    if (_phoneNumbers[i] == name_Or_number)
                        return _names[i];
                }
            }
            else {
                for (int i = 0; i < _names.Length; i++)
                {
                    if (_names[i] == name_Or_number)
                        return _phoneNumbers[i];
                }
            }
                
            return "Not Found";
        }
        set
        {
            if (name_Or_number.StartsWith('0'))
            {
                for (int i = 0; i < _phoneNumbers.Length; i++)
                {
                    if (_phoneNumbers[i] == name_Or_number)
                        _names[i] = value;
                }
            }
            else
            {
                for (int i = 0; i < _names.Length; i++)
                {
                    if (_names[i] == name_Or_number)
                        _phoneNumbers[i] = value;
                }
            }
            

        }

    }
    public string AddContact(string name,string number)
    {
        for(int i = 0; i < 49; i++)
        {
            if (_names[i] == null)
            {
                _names[i] = name;
                _phoneNumbers[i] = number;
                return "Contact has been saved successfully";
            }       
        }
        return "No memory ... Can't store";
    }


}