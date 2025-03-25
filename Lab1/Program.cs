using System.Text.Encodings.Web;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // Step 1, name and title displayed without being declared
        Console.WriteLine("Name: Caleb Lamatrice");
        Console.WriteLine("Course tile: IT-1050");
        /* Step 2, (name and title) milti-line comment
        Name: Caleb Lamatrice
        Title: IT-1050 Lab 1 */
        // Step 3, declare and display variables
        int favnum = 7;
        Console.WriteLine("My favorite number is "+favnum+".");
        string favpro = "html";
        Console.WriteLine("My favorite program so far is "+favpro+".");
        double numpro = 8;
         Console.WriteLine("The number of programs ive written is "+numpro+".");
        bool proexp = true;
        Console.WriteLine(""+proexp+", I do have programming experience.");
        // Step 5, (no step 4) declare constant and display
        const string school = "Tri-c";
        Console.WriteLine(school);
    }
}
