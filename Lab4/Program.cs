namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        /* Problem 1: Simple For Loop
        Creat a for loop that outputs 1-10*/
       
        for (int a = 1; a<= 10; a++)
        {
            Console.WriteLine(a);
        }
        /* Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)
         create a for loop with an if statement that only allows even #'s*/
        for (int b = 1; b <= 20; b++)
        if (b % 2 == 0)
        {
            Console.WriteLine(b);
        }
        /* Problem 3: While Loop Countdown
        creat a while loop that outputs 5-1 counting backwards*/
        int c = 5;
        while (c > 0)
        {
            Console.WriteLine(c--);
        }
        /* Problem 4: Do/While User Input
        Use a do/while loop to prompt the user to enter a number greater than 100.
        Repeat until a valid number is entered.*/
        
        /* Problem 5: While Loop – Multiples of 10 from 10 to 1000
        Use a while loop to print all multiples of 10 starting at 10 and ending at 1000 (inclusive).*/
        int e = 10;
        while (e <= 1000)
        {
            Console.WriteLine(e);
            e += 10;
        }
        /* Pattern Printer (Using Nested Loops)
        Use nested for loops to print the following triangle pattern*/
        int rows = 10;
        for (int f = 1; f<= rows; f++)
        {
            for (int g = 1; g<=f; g++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
       
    }
}
