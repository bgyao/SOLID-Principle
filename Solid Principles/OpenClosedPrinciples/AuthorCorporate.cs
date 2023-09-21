namespace Solid_Principles.OpenClosedPrinciples;

public class AuthorCorporate : Author
{
    public override int MarcCode { get => base.MarcCode; set => base.MarcCode = isMainEntry ? 110 : 710; }
    public override string FullName => base.FullName = FirstName;


    public override void SetEntityAsAuthor (int entryType, string corporateName, bool isMainEntry)
    {
        MarcCode = isMainEntry ? 110 : 710;

        if (entryType == 0)
            Console.WriteLine("Inverted name of the Corporate entity will be used");
        else if (entryType == 1)
            Console.WriteLine("Jurisdiction name of the Corporate entity will be used");
        else if (entryType == 2)
            Console.WriteLine("Name in direct order of the Corporate entity will be used");
        else
            Console.WriteLine("NOTICE: entryType is undefined. Default # will be used.");
    }
}
