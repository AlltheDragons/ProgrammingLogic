namespace Lab7;

class Book
{
    private string title;
    private string author;

    public Book()  // Default Constructor
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }
    public string GetTitle()
    {
        return title;
    }
    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }
    public string GetAuthor()
    {
        return author;
    }
    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //problem 1
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  // Output: Unknown Title
        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());  // Output: C# Fundamentals
        //problem 2
        Book book2 = new Book("Advanced C#","");
        Console.WriteLine(book2.GetTitle());  // Output: Advanced C#
        //problem 3
        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine("Title: " + book3.GetTitle());    //Output: Title: Advanced C#
        Console.WriteLine("Author: " + book3.GetAuthor());  //Output: Author: John Doe
        //problem 4
        Book book4 = new Book("unknown title", "Unknown author");
        book4.SetTitle("Mastering C#");
        book4.SetAuthor("Jane Smith");
        Console.WriteLine("Title: " + book4.GetTitle());    //Outputs SetTitle: Mastering C#
        Console.WriteLine("Author: " + book4.GetAuthor());  //Outputs SetAuthor: Jane Smith

    }
}
