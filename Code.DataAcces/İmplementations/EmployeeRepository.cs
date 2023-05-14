using CodeAcademy.Core.Entities;

namespace Code.DataAcces.İmplementations;

public class EmployeeRepository : IRepository<Employee>
{
    public void Add(Employee entity)
    {
        DbContext.DbContext.Employees.Add(entity);
    }

    public void Delete(Employee entity)
    {
        DbContext.DbContext.Employees.Remove(entity);
    }
    public void Update(Employee entity)
    {
       Employee? Emp = DbContext.DbContext.Employees.Find(Emp => Emp.EmployeeId == entity.EmployeeId);
        Emp.Name=entity.Name;
        Emp.Surname=entity.Surname;
    }

    public Employee? Get(int id)
    {
        return DbContext.DbContext.Employees.Find(Emp => Emp.EmployeeId == id);
    }

    public List<Employee> GetAll()
    {
        return DbContext.DbContext.Employees;
    }

}
