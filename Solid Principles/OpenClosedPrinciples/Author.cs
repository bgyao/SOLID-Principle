using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.OpenClosedPrinciples;

public abstract class Author
{
    public Guid AuthorId { get { return new Guid(); } }
    public string FirstName { get; set; }
    public string? SecondName { get; set; }
    public virtual string FullName { get; set; }
    public virtual string FullNameInverse { get; set; }
    public bool isMainEntry { get; set; }
    public int entryType { get; set; }
    public virtual int MarcCode { get; set; }
    public abstract void SetEntityAsAuthor(int entryType, string corporateName, bool isMainEntry);
}
