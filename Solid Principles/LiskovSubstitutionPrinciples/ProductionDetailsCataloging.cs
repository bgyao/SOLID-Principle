using Solid_Principles.LiskovSubstitutionPrinciples.PublicationDetails;

namespace Solid_Principles.LiskovSubstitutionPrinciples;

public class ProductionDetailsCataloging
{
    public static void Main()
    {
        var copyrightDetail = new CopyrightDetail()
        {
            CopyrightHolder = "HarperCollins",
            CopyrightPlace = "New York, NY",
            CopyrightDate = new DateOnly(2022, 10, 30)
        };

        var publisherDetail = new PublisherDetail()
        {
            PublicationPlace = "Washington, DC",
            PublisherName = "Penguin Publication",
            PublicationDate = new DateOnly(2023, 1, 15)
        };

        copyrightDetail.PrintPublicationDetails();
        publisherDetail.PrintPublicationDetails();

        Console.ReadKey();
    }
    
}
