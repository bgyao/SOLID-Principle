namespace Solid_Principles.LiskovSubstitutionPrinciples.PublicationDetails;

public class CopyrightDetail : PublicationDetail
{
    public string? CopyrightPlace { get; set; }
    public string? CopyrightHolder { get; set; }
    public DateOnly CopyrightDate { get; set; }
    public string? MaterialsSpecified { get; set; }
    public string? Linkage { get; set; }
    public Guid DataProvenance { get { return new Guid(); } }
    public Guid SequenceNumber { get { return new Guid(); } }

    public override void PrintPublicationDetails()
    {
        CopyrightPlace ??= "[place of copyright not identified]";
        CopyrightHolder ??= "[publisher not identified]";

        Console.WriteLine($"264 #1 $a{CopyrightPlace} : $b{CopyrightHolder}, $c &copy;{CopyrightDate.Year}.");
    }
}
