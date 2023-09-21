using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid_Principles.SingleResponsibilityPrinciples.DescriptiveCatalogings;

namespace Solid_Principles.OpenClosedPrinciples;

public class AuthorCorporate
{
    public Author Author { get; set; } = new();
    public int MarcCode { get; set; }

    public async Task <Author> SetCorporateEntityAsAuthor (int entryType, string corporateName, bool isMainEntry)
    {
        if (entryType == 0)
            Console.WriteLine("Inverted name of the Corporate entity will be used");
        else if (entryType == 1)
            Console.WriteLine("Jurisdiction name of the Corporate entity will be used");
        else if (entryType == 2)
            Console.WriteLine("Name in direct order of the Corporate entity will be used");
        else
            Console.WriteLine("NOTICE: entryType is undefined. Default # will be used.");

        if (isMainEntry)
            MarcCode = 110;
        else
            MarcCode = 710;

        Author = new Author()
        {
            entryType = entryType,
            FirstName = corporateName,
            SecondName = " ",
            isMainEntry = isMainEntry,
        };

        return Author;
    }
}
