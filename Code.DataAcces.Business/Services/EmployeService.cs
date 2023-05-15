using Code.DataAcces.Business.Exceptions;
using Code.DataAcces.Business.Helpers;
using Code.DataAcces.Business.Interfaces;
using Code.DataAcces.Business.Services;
using Code.DataAcces.DbContext;
using Code.DataAcces.İmplementations;
using CodeAcademy.Business.Exceptions;
using CodeAcademy.Business.Interfaces;
using CodeAcademy.Core.Entities;

namespace CodeAcademy.Business.Services;

public class EmployeService : İEmployeeService
{
    public void Create(Employee employee)
    { }
         public EmployeeRepository employeeRepository { get; }
    public EmployeService()
    {
        employeeRepository = new EmployeeRepository();
    }
    
    public void create(string name, string surname, int salary)
    {
        var Name = name.Trim();
        if (string.IsNullOrWhiteSpace(Name))
        {
            throw new SizeException(Helper.Errors["Size Exception"]);
        }
        if (employeeRepository.GetByName(Name) != null)
        {
            throw new AllreadyExistException(Helper.Errors["AllreadyExistException"]);
        }
        Employee employee = new Employee();
        employeeRepository.Add(employee);
    }
      

    public void Delete(int id)
    {
        var employee = DbContext.Employees.Find(emp => emp.EmployeeId == id);
        if (employee != null)
        {
            employeeRepository.Delete(employee);
        }
        else
        {
            throw new NotFoundException(Helper.Errors["NotFoundException"]);
        }
    }
    public List<Employee> GetAll(int skip, int take)
    {
        return DbContext.Employees.FindAll(emp => emp.EmployeeId <= take && emp.EmployeeId >= skip);
    }

    public Employee GetEmployeeById(int id)
    {
        var count = DbContext.Employees.Count(emp => emp.EmployeeId == id);
        if (count < id)
        {
            throw new NotFoundException("This Id doesn't exist");
        }
        return DbContext.Employees.Find(emp => emp.EmployeeId == id);
    }

    public List<Employee> GetEmployeeByName(string name)
    {
        var employee = employeeRepository.GetByName(name);
        if (employee == null)
        {
            throw new NotFoundException("This employee was not found");
        }
        return DbContext.Employees.FindAll(emp => emp.Name == name);
    }

    public void Update(int id, Employee employee)
    {
        throw new NotImplementedException();
    }

    public void UpdateEmployeeSalary(int id, double salary)
    {
        throw new NotImplementedException();
    }
}
