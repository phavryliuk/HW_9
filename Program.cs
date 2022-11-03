public class Library
{
    public static string BookName { get; set; }
    public static string BookAuthor { get; set; }
    public static int BookId { get; set; }
}


public class Output
{ 
    public static void Main()

    {
            Library.BookName = "Kobzar";
            Library.BookAuthor = "Taras Shevchenko";
            Library.BookId = 0001;
           
            Console.WriteLine(Library.BookName);
            Console.WriteLine(Library.BookAuthor);
            Console.WriteLine(Library.BookId);

        

    }
}

