using System.Reflection.Metadata;

namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        /* Problem 1: Seasons of the Year
        use string array and foreach loop to display season names*/
        string[] seasons = new string[4];
        seasons [0] = "Spring";
        seasons [1] = "Summer";
        seasons [2] = "Fall";
        seasons [3] = "Winter";

        foreach (string name in seasons)
        {
            Console.WriteLine(name);
        }
        /* Problem 2: Days of the Week (1–7)
        */
        string[] days = new string[7];
        days [0] = "Monday";
        days [1] = "Tuesday";
        days [2] = "Wednesday";
        days [3] = "Thursday";
        days [4] = "Friday";
        days [5] = "Saturday";
        days [6] = "Sunday";
        int input;
        foreach (string name in days)
        {
            Console.Write("Enter a number (1-7) for a day of the week:");
            input = Convert.ToInt32(Console.ReadLine());
            if (input > 0)
            {
               Console.WriteLine("Day " + input + " = " + days[input-1]);
            }
            else if (input < 7)
            {
                Console.WriteLine("Day " + input + " = " + days[input-1]);
            }
            else
            {
                Console.WriteLine("You didn't enter a valid number.");
            }
        } 
        /* Problem 3: Favorite Books and Authors
        */
        string[] books = new string [3];
        books[0] = "The hobbit";
        books[1] = "Charlotte's Web";
        books[2] = "1984";

        string[] authors = new string [3];
        authors[0] = "J.R.R. Tolkien";
        authors[1] = "E.B. White";
        authors[2] = "George Orwell";

        /* Problem 4: Temperature Tracker
        */
        int [] temperatures = { 65, 72, 78, 70, 68 };
         // Sorting the array in ascending order
         Array.Sort(temperatures);

         Console.WriteLine("Sorted Temperatures:");
         foreach (int num in temperatures) 
         {
            Console.Write(num + " ");
         }
        /* Problem 5: Reverse Countdown
        */
        int[] countdown = { 5, 4, 3, 2, 1 };

         // Sorting the array in descending order
         Array.Sort(countdown);
         Array.Reverse(countdown);

         Console.WriteLine("Sorted Array in Descending Order:");
         foreach (int num in countdown) {
            Console.Write(num + " ");
         }
        
    }
}
