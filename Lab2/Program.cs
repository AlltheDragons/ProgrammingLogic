namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        /* step 1: variable declarations
        (creating my own variables and printing them)*/
        int mynum = 7;
        double mydoublenum = 6.7D;
        float myfloatnum = 7.6F;
        char myletter = 'C';
        bool mytruth = true;
        string mymessage = "This is a message, nothing interesting happening here.";
        Console.WriteLine("My integer variable is "+mynum+".");
        Console.WriteLine("My double variable is "+mydoublenum+".");
        Console.WriteLine("My float variable is "+myfloatnum+".");
        Console.WriteLine("My letter is "+myletter+".");
        Console.WriteLine("Is it "+mytruth+" that this is a bool variable?");
        Console.WriteLine(""+mymessage+" Unless it's a string variable.");

        /* step 2: Type casting
        (implicit casting and conversion methods)*/
        double castdoublenum = 9.78;
        int castnum = (int)castdoublenum;
        Console.WriteLine("double: "+castdoublenum+"");
        Console.WriteLine("integer: "+castnum+"");
        Console.WriteLine(Convert.ToString(mynum));
        Console.WriteLine(Convert.ToString(mytruth));

        /* step 3: User input and type conversion
        (allow user input and declare it)*/
        Console.WriteLine("Enter name:");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hello " +name+ ", you are " +age+".");

        /* step 4: Arithmetic operations
        (pick 2 numbers and operate on them)*/
        int num1 = 7;
        int num2 = 6;
        Console.WriteLine("Arithmic operations for " +num1+ ".");
        Console.WriteLine(num1 + 10);
        Console.WriteLine(num1 - 2);
        Console.WriteLine(num1 * 3);
        Console.WriteLine(num1 / 2);
        Console.WriteLine(num1 % 2);
        Console.WriteLine("Arithmic operations for " +num2+ ".");
        Console.WriteLine(num2 + 10);
        Console.WriteLine(num2 - 2);
        Console.WriteLine(num2 * 3);
        Console.WriteLine(num2 / 2);
        Console.WriteLine(num2 % 2);

        /* step 5: Floating point precision
        (float vs. double)*/
        float vsfloatnum = 1.123456789F;
        double vsdoublenum = 1.123456789D;
        //double is more accurate
        Console.WriteLine(+vsfloatnum);
        Console.WriteLine(+vsdoublenum);

        /* step 6: Increment and Decrement
        (increasing/decreasing a number by small amounts)*/
        int num = 10;
        num++;
        Console.WriteLine(num);
        num--;
        Console.WriteLine(num);

    }
}
