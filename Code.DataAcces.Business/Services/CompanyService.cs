using Code.DataAcces.Business.Exceptions;
using Code.DataAcces.Business.Helpers;
using Code.DataAcces.Business.Interfaces;
using Code.DataAcces.İmplementations;
using CodeAcademy.Business.Exceptions;
using CodeAcademy.Core.Entities;
using System.Xml.Linq;

namespace Code.DataAcces.Business.Services;

public class CompanyService : ICompanyService
{
    public CompanyRepository companyTypeRepository { get; }
    public CompanyService()
    {
        companyTypeRepository = new CompanyRepository();
    }
    public void create(string type, string surname, int salary)
    {
        var exist = companyTypeRepository.GetByName(type);
        if (exist != null) 
        {
            throw new AllreadyExistException(Helper.Errors["AllreadyExistException"]);
        }
        string name =type.Trim();
        if(name.Length <= 2) 
        {
            throw new SizeException(Helper.Errors["SizeException"]);
        }
        Company companyType = new Company(name);
        companyTypeRepository.Add(companyType);
    }

    public void Delete(string type)
    {
        var company = DbContext.DbContext.Companys.Find(c => c.Name == type);
        if (company != null)
        {
            companyTypeRepository.Delete(company);
        }
        else
        {
            throw new NotFoundException("This company doesn't exist");
        }
        var count = DbContext.DbContext. Companys.Count(c => c.Name == type);
        if (count != 0)
        {
            throw new NotFoundException("This company isn't empty");
        }
    }

    public List<Company> GetAll()
    {
        return companyTypeRepository.GetAll(); 
    }

    public Company GetById(int id)
    {
        var count = DbContext.DbContext.Companys.Count();
        if (count < id)
        {
            throw new NotFoundException("This Id doesn't exist");
        }
        return DbContext.DbContext.Companys.Find(c => c.CompanyId == id);
    }
}
