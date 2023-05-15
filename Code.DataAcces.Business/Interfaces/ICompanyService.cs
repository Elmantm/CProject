using CodeAcademy.Core.Entities;

namespace Code.DataAcces.Business.Interfaces;

public interface ICompanyService
{
    void create(string name,string surname,int salary);
    void Delete(string name);
    Company GetById(int id);
    List<Company> GetAll();
    
}
