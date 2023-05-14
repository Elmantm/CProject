using CodeAcademy.Core.Interfaces;

namespace CodeAcademy.Core.Entities;

public class CompanyType:IEntity
{
    private static int _id;
    public string Name { get; set; }
    public int CompanyId { get; }
    public CompanyType()
    {
        CompanyId = _id;
        _id++;
    }
    public CompanyType(string name) : this()
    {
        Name = name;
    }
}
