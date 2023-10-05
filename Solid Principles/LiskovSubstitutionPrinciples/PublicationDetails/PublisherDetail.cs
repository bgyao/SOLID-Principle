namespace Solid_Principles.LiskovSubstitutionPrinciples.PublicationDetails;

// Based on MARC 264 - Production, Publication, Distribution, Manufacture, and Copyright Notice (R)
// For this exercise, LSP will be demonstrated by using PublicationDetail as the abstract class,
// then PublisherDetail (2nd Indicator = 1) and CopyrightDetail (2nd Indicator = 4)
// will inherit the PublicationDetail.
public class PublisherDetail : PublicationDetail
{
    public string? PublicationPlace { get; set; }
    public string? PublisherName { get; set; }
    public DateOnly PublicationDate { get; set; }
    private string PublicationYear = "[year of publication not identified]";
    public string? MaterialsSpecified { get; set; }
    public string? Linkage { get; set; }
    public Guid DataProvenance { get { return new Guid(); } }
    public Guid SequenceNumber { get { return new Guid(); } }

    public override void PrintPublicationDetails()
    {
        PublicationPlace ??= "[place of publication not identified]";

        PublisherName ??= "[publisher not identified]";

        if(PublicationDate.ToString() is not null)
        {
            Console.WriteLine($"264 #1 $a{PublicationPlace} : $b{PublisherName}, $c{PublicationDate.Year}.");
        }
        else
        {
            Console.WriteLine($"264 #1 $a{PublicationPlace} : $b{PublisherName}, $c{PublicationYear}.");
        }
        
    }
}
