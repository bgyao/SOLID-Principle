namespace Solid_Principles.SingleResponsibilityPrinciples.DescriptiveCatalogings;

public class BookDetails
{
    public Guid id = new Guid();
    public string bookTitle;
    public string? bookSubtitle;
    public string? edition;

    public void PrintBookBasicDetails()
    {
        var displayDetails = $"This book is titled {bookTitle}";

        if (!string.IsNullOrEmpty(bookSubtitle))
        {
            displayDetails = string.Join(" : ", displayDetails, bookSubtitle);
        }

        displayDetails = string.Join(", ", displayDetails, edition);
        Console.WriteLine(displayDetails);
    }
 
}

public class Author
{
    public Guid AuthorId = new Guid();
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string FullName { get { return $"{FirstName} {SecondName}"; } }
    public string FullNameInverse { get { return $"{SecondName}, {FirstName}"; }  }
    public bool isMainEntry { get; set; }
    public int entryType { get; set; }

    public void AuthorNotice()
    {
        Console.WriteLine("This class is responsible for processing the resource's Statement of Responsibility Personal Name.");
    }
}
