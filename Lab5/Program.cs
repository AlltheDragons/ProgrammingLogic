namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
    /* Problem 1: Seasons of the Year
    use string array and foreach loop to display season names*/
    string[] seasons = new string[4];
    seasons[0] = "Spring";
    seasons[1] = "Summer";
    seasons[2] = "Fall";
    seasons[3] = "Winter";

    foreach (string name in seasons)
    {
    Console.WriteLine(name);
    }
    /* Problem 2: Days of the Week (1–7)
    create array and have user input display array contents*/
    string[] days = new string[7];
    days[0] = "Monday";
    days[1] = "Tuesday";
    days[2] = "Wednesday";
    days[3] = "Thursday";
    days[4] = "Friday";
    days[5] = "Saturday";
    days[6] = "Sunday";
    Console.Write("Enter a number (1-7) for a day of the week: ");
    int input = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Day " + input + " = " + days[input-1]);
    
    /* Problem 3: Favorite Books and Authors
    create arrays and order them based on contents*/
    //declare arrays
    string[] books = {"The hobbit", "Charlotte's Web", "1984"};
    string[] authors = {"J.R.R. Tolkien", "E.B. White", "George Orwell"};
    //display arrays
    for (int i = 0; i < books.Length; i++)
    {
        Console.WriteLine($"books[{i}]: {books[i]}, by {authors[i]}");
    }
    /* Problem 4: Temperature Tracker
    creat and display a sorted array*/
    int[] temperatures = { 65, 72, 78, 70, 68 };
    // Sorting the array
    Array.Sort(temperatures);
    Console.WriteLine("Sorted Temperatures:");
    foreach (int num in temperatures)
    {
        Console.Write(num + " ");
    }
    //highest and lowest in array
    int highest = temperatures.Max();
    int lowest = temperatures.Min();
    //display high and low temps
    Console.WriteLine("Highest temperature: " + highest);
    Console.WriteLine("Lowest temperature: " + lowest);
    /* Problem 5: Reverse Countdown
     create and sort an array in descending order*/
    int[] countdown = { 5, 4, 3, 2, 1 };
    //sorting array
    Array.Sort(countdown);
    Array.Reverse(countdown);
    //displaying sorted array
    Console.WriteLine("Sorted Array in Descending Order:");
    foreach (int num in countdown)
    {
        Console.Write(num + " ");
    }
}
}