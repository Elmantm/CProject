

using CodeAcademy.Core.Entities;

namespace CodeAcademy.Business.Interfaces;

public interface İEmployeeService
{
    void Create(Employee employee);
    void Delete(int id);
    void Update(int id,Employee employee);
    void UpdateEmployeeSalary(int id, double salary);
    List<Employee> GetAll(int skip,int take);
    List<Employee> GetEmployeeByName(string name);
    Employee GetEmployeeById(int id);

}
