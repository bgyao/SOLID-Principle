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
