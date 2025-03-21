 class Student {
    static void Main(String[] args)
    {
        Console.WriteLine("Enter your name : ");
       var name = Console.ReadLine();
        Console.WriteLine("Enter your age : ");
       var age =  Console.ReadLine();
        Console.WriteLine("Enter first score : ");
       var exam1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second score : ");
       var exam2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third score : ");
       var exam3 = Convert.ToInt32(Console.ReadLine());

        var avg = (exam1 + exam2 + exam3) / 3.0;

        char grade;
        if (exam1 >= 0 && exam1 <=100 && exam2 >= 0 && exam2 <= 100 && exam3 >= 0 && exam3 <= 100 )
        {
            if (avg >= 90 && avg <= 100) grade = 'A';
            else if (avg >= 80) grade = 'B';
            else if (avg >= 70) grade = 'C';
            else if (avg >= 60) grade = 'D';
            else grade = 'F';
            Console.Write($"Hello {name}, you are {age} years old\nYour average score is {avg}\nYour grade is {grade}");
        }else
        {
            Console.WriteLine("Error : invalid scores");
        }
    }
}