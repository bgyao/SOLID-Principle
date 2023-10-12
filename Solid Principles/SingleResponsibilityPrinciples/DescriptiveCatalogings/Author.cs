namespace Solid_Principles.SingleResponsibilityPrinciples.DescriptiveCatalogings;

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
        Console.WriteLine("MARC CODE:");
        Console.WriteLine($"100 {entryType}# $a{FullNameInverse}, author.");
        Console.WriteLine("This class is responsible for processing the resource's Statement of Responsibility Personal Name.");
    }
}
