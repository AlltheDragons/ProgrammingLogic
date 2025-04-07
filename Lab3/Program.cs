namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        /* Part 1: Operator practice
        Deglare integers and compare them*/
        int a = 10;
        int b = 5;
        int c = 15;
        Console.WriteLine(a>b);
        Console.WriteLine(a<c);
        Console.WriteLine(a>b&&a>c);
        /* Part 2: Boolean Logic
        Declare bools and use if statements to print*/
        bool isRaining = true;
        bool haveUmbrella = false;
        if (isRaining)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else if (haveUmbrella)
        {
            Console.WriteLine("You're good to go!");
        }
        /* Part 3: Conditional Logic – Movie Ticket Pricing
        Have a user input an age and give ticket prices based off of age*/
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age<5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age>=5&&age<=12)
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (age>=13&&age<=64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else if (age>=65)
        {
            Console.WriteLine("Senior ticket: $6");
        }
        /* Part 4: Using a switch Statement
        Use switch statements to display days of the week based on user input*/
        Console.WriteLine("Enter a day of the week (1-7):");
        int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:
            Console.WriteLine("Monday");
            break;
            case 2:
            Console.WriteLine("Tuesday");
            break;
            case 3:
            Console.WriteLine("Wednesday");
            break;
            case 4:
            Console.WriteLine("Thursday");
            break;
            case 5:
            Console.WriteLine("Friday");
            break;
            case 6:
            Console.WriteLine("Saturday");
            break;
            case 7:
            Console.WriteLine("Sunday");
            break;
          
        }  
        if (day>=8)
            {
                Console.WriteLine("invalid day!");
            }

    }
}
