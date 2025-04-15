using System;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter student name : ");
        string name = Console.ReadLine();
        Console.Write("Enter school name : ");
        string school = Console.ReadLine(); 
        Console.Write("Enter phone number : ");
        string phone = Console.ReadLine();
        Console.Write("Enter student religion : ");
        string religion = Console.ReadLine();
        student s1 = new student(name, school, phone,religion);

        Console.WriteLine($"student's name : {s1.name}\n" +
                          $"student's school : {s1.schoolName}\n" +
                          $"student's phone : {s1.phone}\n" +
                          $"student's religion : {s1.religion}\n" +
                          $"student's city : {s1.city} \n");


    }
}


public class student
{
    public const short tuitionFees_Dollar = (short)1200;
    private string _phone;
    private string _religion;


    public student ( String name, string schoolName, string phone, string religion)
    {
        this.name = name;//property name = parameter name
        this.schoolName = schoolName;//property schoolName = parameter schoolName
        this.phone = phone;  //property phone = parameter phone
                             //this._phone = phone ; is wrong as it will give {_phone}field the value directly without go through the property{phone}
        this._religion = religion; //this.religion = religion; is wrong as it will go through {religion}field whcich is readonly property(doesn't have set)
    }

    public string name { get; } // set in the constructor and can't be re-set (readOnly property)
                                // you can't declare such variable as a field (it's backing field)  
    public string schoolName { get; set; } //set in the constructor and can be re-set via property 
                                           //you can't declare such variable as a field (it's backing field)  
    public string city { get; } = "Zagazig"; //can't be set in the constructor and can't be changed like costant 
                                             //you call it using objectName unlike constant which is called by className
                                             //you can't declare such variable as a field (it's backing field)
    public string religion   // can't be set in constructor so i used _religion as an intermediate backing field and can't be re-set (readOnly property).
                             // like property name but gives me a chance to do some processes like validation before get the variable .
    {
        get
        {
            if (_religion == "Muslim" || _religion == "Christian" || _religion == "Jew")
            {
                return this._religion;
            }
            else
            {
                return "Unknown";
            }
        }


    }

    public string phone // can't be set in constructor so i used _phone as an intermediate backing field .
                        // like property schoolName but gives me a chance to do some processes like validation before get or set the variable .
    {
        get
        {
            return this._phone;
        }
        set
        {
            if (value.Length == 11)
            {

                if (value.StartsWith("010") || value.StartsWith("011") || value.StartsWith("012") || value.StartsWith("015"))
                {
                    _phone = value;

                }
                else
                {
                    _phone = "000";
                }
            }else
            {
                    _phone = "000";
            }
        }
    }
}