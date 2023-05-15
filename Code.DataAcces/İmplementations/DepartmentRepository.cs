using CodeAcademy.Core.Entities;

namespace Code.DataAcces.İmplementations;

public class DepartmentRepository : IRepository<Department>
{
    public void Add(Department entity)
    {
        DbContext.DbContext.Departments.Add(entity);
    }

    public void Delete(Department entity)
    {
        DbContext.DbContext.Departments.Remove(entity);
    }

    public void Update(Department entity)
    {
        Department? Dep = DbContext.DbContext.Departments.Find(Dep => Dep.DepartmentId == entity.DepartmentId);
        Dep.Name = entity.Name;
        Dep.EmployeeLimit = entity.EmployeeLimit;
    }
    public Department? Get(int id)
    {
        return DbContext.DbContext.Departments.Find(D => D.DepartmentId == id);
    }

    public List<Department> GetAll()
    {
        return DbContext.DbContext.Departments;
    }

    public Department? GetByName(string name)
    {
        return DbContext.DbContext.Departments.Find(g => g.Name == name);
    }

    public List<Department> GetAllByName(string name)
    {
        return DbContext.DbContext.Departments.FindAll(Empt=>Empt.GetType==GetAllByName);
    }
}
