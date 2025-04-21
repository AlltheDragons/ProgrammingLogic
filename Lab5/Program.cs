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
        days [1] = "Monday";
        days [2] = "Tuesday";
        days [3] = "Wednesday";
        days [4] = "Thursday";
        days [5] = "Friday";
        days [6] = "Saturday";
        days [7] = "Sunday";
        int input;
        do
        {
            Console.Write("Enter a number (1-7):");
            input = Convert.ToInt32(Console.ReadLine());
            if (input > 0)
            {
                Console.WriteLine("That day is:"+days);
            }
            else if (input < 8)
            {
                Console.WriteLine("That day is:"+days);
            }
            else
            {
                Console.WriteLine("You didn't enter a valid number.");
            }
        } while (input <= 7);
        /* Problem 3: Favorite Books and Authors
        */

        /* Problem 4: Temperature Tracker
        */

        /* Problem 5: Reverse Countdown
        */
        
    }
}
