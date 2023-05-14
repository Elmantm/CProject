using CodeAcademy.Core.Entities;

namespace Code.DataAcces.İmplementations;

public class CompanyTypeRepository : IRepository<CompanyType>
{
    public void Add(CompanyType entity)
    {
        DbContext.DbContext.Companys.Add(entity);
    }

    public void Delete(CompanyType entity)
    {
        DbContext.DbContext.Companys.Remove(entity); 
    }

    public void Update(CompanyType entity)
    {
        CompanyType? Com = DbContext.DbContext.Companys.Find(Com => Com.CompanyId ==entity.CompanyId);
        Com.Name=entity.Name;
    }
    public CompanyType? Get(int id)
    {
        return DbContext.DbContext.Companys.Find(Com => Com.CompanyId == id);
    }

    public List<CompanyType> GetAll()
    {
        return DbContext.DbContext.Companys;
    }

}
