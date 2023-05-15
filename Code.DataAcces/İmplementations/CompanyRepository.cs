using CodeAcademy.Core.Entities;

namespace Code.DataAcces.İmplementations;

public class CompanyRepository : IRepository<Company>
{
    public void Add(Company entity)
    {
        DbContext.DbContext.Companys.Add(entity);
    }

    public void Delete(Company entity)
    {
        DbContext.DbContext.Companys.Remove(entity); 
    }

    public void Update(Company entity)
    {
        Company? Com = DbContext.DbContext.Companys.Find(Com => Com.CompanyId ==entity.CompanyId);
        Com.Name=entity.Name;
    }
    public Company? Get(int id)
    {
        return DbContext.DbContext.Companys.Find(Com => Com.CompanyId == id);
    }
    public Company? GetbyName(string name,string surname)
    {
        return DbContext.DbContext.Companys.Find(Com => Com.Name == name);
    }

    public List<Company> GetAll()
    {
        return DbContext.DbContext.Companys;
    }

    public Company GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public List<Company> GetAllByName(string name)
    {
       return DbContext.DbContext.Companys.FindAll(Com => Com.Name == name);
    }
}
