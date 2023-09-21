using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.OpenClosedPrinciples;

public class AuthorPersonal : Author
{
    public override string FullName { get => base.FullName; set => base.FullName = $"{FirstName} {SecondName}"; }
    public override string FullNameInverse { get => base.FullNameInverse; set => base.FullNameInverse = $"{SecondName}, {FirstName}"; }

    public override void SetEntityAsAuthor(int entryType, string corporateName, bool isMainEntry)
    {
        MarcCode = isMainEntry ? 100 : 700;

        if (entryType == 0)
            Console.WriteLine($"Forename is selected. {FullName} will be used.");
        else if (entryType == 1)
            Console.WriteLine($"Personal Name is selected. {FullNameInverse} will be used.");
        else if (entryType == 3)
            Console.WriteLine("Family Name will be displayed.");
        else
            Console.WriteLine("NOTICE: entryType is undefined. Default # will be used.");
    }
}
