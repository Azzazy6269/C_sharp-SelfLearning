using System.Runtime.CompilerServices;

class Program
{
    static void Main (string[] args)
    {
        /* you don't have to call a constructor while creating a struct unlike class
         * but this can happen only if you don't have fields
         */
        student1 s1;
        s1.show();   
        /* if you have fields you have to intialize them 
         * or you have to call a constructor with parameters so it gives them values 
         * or you have to call the default constructor so it gives them default values of their dataTypes
         */
        student2 s2;
        s2.id = 12;
        s2.show();
        student2 s2_ = new student2();
        s2_.show();
        /* even if you intialized the field in the struct itself , you have to reintialize it again or call a constructor
           because when you write 'student3 s3;' you have declared the object but you haven't intialized it yet so the compiler can't treat with it
           you have to call any constructor to intialize the object or at least you have to intialize all fields and properties to intialize the object
         */
        student3 s3 = new student3();
        s3.show();
        /*in class you always have to call a constructor */
        student_class s;
        s = new student_class();
        s.show();

        student4 s4 = new student4(62);
        s4.show();


        /*at the end
         You have to know that most datatypes are readonly structs 
        */
        int x = 5;
        x =  x + 1; 
        /*string is a class */
        string y = "Hello";
        y = "Hello there"; // string is a class so it's reference type which means y is in stack but reference to its data in heap
        // so you refrenced to the new data by the same y
        // the old data is still there in heap but with no variable in stack reference to it so the garbage collector will delete it 

    }
}

//Summary about differences between structs and classes
/* There's no inheretence in struct
 * There's no finalizer 
 * It's stored in stack because it's value type: the object itself and it's data are all stored in stack 
   unlike class which it's object only is stored in stack but the data in heap because it's reference type
 * not recomended for large data
 * you can declare a struct object without calling any constructors if it doesn't have any variables or you have to intialize each variable manually 
   unlike class which you have to call a constructor while declaring it 
 * You can create readonly struct but there's no readonly class
 */
struct student1
{
    public student1()
    {
        Console.WriteLine("Object of student1 has been created ");

    }
    public void show()
    {
        Console.WriteLine("This is a student1 object");
    }
}

struct student2
{
    public int id ; 
    public student2(int ID) //Although you defined a constructor with parameters , the default parameterless constructor still available 
    {
        Console.WriteLine("Object of student2 has been created ");
    }
    public void show()
    {
        Console.WriteLine("This is a student2 object");
    }
}

struct student3
{
    public int id = 7;
    public student3()
    {
        Console.WriteLine("Object of student3 has been created ");

    }
    public void show()
    {
        Console.WriteLine("This is a student3 object");
    }
}

readonly struct student4 // readonly makes it immutable so you have to make all fields readonly
                         // if you wrote any method to modify values it would cause error 
{
    public readonly int id = 7;
    public student4(int id)
    {
        this.id = id;
        Console.WriteLine("Object of student4 has been created ");
    }
    public void show()
    {
        Console.WriteLine("This is a student4 object");
    }
}

class student_class
{
    private int id;
    public void show()
    {
        Console.WriteLine("This is a student_class object");
    }
}
