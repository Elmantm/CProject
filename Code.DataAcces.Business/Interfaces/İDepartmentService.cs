using CodeAcademy.Core.Entities;

namespace Code.DataAcces.Business.Interfaces;

public interface İDepartmentService
{
    void Create(string departmentname,string typename, int capacity);
    void Delete(string departmentname);
    void update(int id, int capacity);
    Department GetbyName(string departmentname);
    Department GetByIld(int id);
    List<Department> GetAll();
}
