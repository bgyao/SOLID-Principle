namespace Solid_Principles.SingleResponsibilityPrinciples.DescriptiveCatalogings;

public class Program
{
    private bool marcMainEntry;
    public void Main(string[] args)
    {
        Console.WriteLine("Enter book details:");
        
        Console.WriteLine("Book Title:");
        string? title = Console.ReadLine();
        while (title is null)
        {
            Console.WriteLine("Book Title is required:");
            title = Console.ReadLine();
        }

        Console.WriteLine("Book Subtitle:");
        string? subtitle = Console.ReadLine();

        Console.WriteLine("Book Edition:");
        string? edition = Console.ReadLine();

        BookDetails bookDetails = new BookDetails()
        {
            bookTitle = title,
            bookSubtitle = subtitle,
            edition = edition
        };

        Console.WriteLine("Enter book author:");

        Console.WriteLine("Author Surname:");
        string? surname = Console.ReadLine();
        while (surname is null)
        {
            Console.WriteLine("Author Surname is required:");
            surname = Console.ReadLine();
        }

        Console.WriteLine("Author Given Name:");
        string? givenName = Console.ReadLine();
        while (givenName is null)
        {
            Console.WriteLine("Author Given Name is required:");
            surname = Console.ReadLine();
        }

        Console.WriteLine("Is this a main entry? If Yes, type 1; If No, type 0:");
        string? mainEntry = Console.ReadLine();
        while(mainEntry != "1" || mainEntry != "2" || mainEntry is null)
        {
            Console.WriteLine("Is this a main entry? If Yes, type 1; If No, type 0:");
            mainEntry = Console.ReadLine();
        }
        if (mainEntry == "1")
        {
            marcMainEntry = true;
        }
        else
        {
            marcMainEntry = false;
        }


        Author bookAuthor = new Author()
        {
            FirstName = givenName,
            SecondName = surname,
            isMainEntry = marcMainEntry,
            entryType = 1
        };

        bookDetails.PrintBookBasicDetails();
        bookAuthor.AuthorNotice();
    }
}
