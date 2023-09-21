using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.OpenClosedPrinciples;

public class StatementOfResponsibility
{
    public StatementOfResponsibility()
    {

    }
    AuthorCorporate authorCorporate { get; set; }
    AuthorPersonal authorPersonal { get; set; }

    public async Task <Author> SetPersonalNameAsAuthor()
    {
        authorPersonal = new()
        {
            isMainEntry = true,
            entryType = 1,
            SecondName = "Ibarra",
            FirstName = "Crisostomo"
        };

        return authorPersonal;
    }

    public async Task <Author> SetCorporateEntityAsAuthor()
    {
        authorCorporate = new()
        {
            isMainEntry = false,
            entryType = 2,
            FirstName = "My Company Inc."
        };

        return authorCorporate;
    }
}
