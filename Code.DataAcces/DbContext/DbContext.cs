using CodeAcademy.Core.Entities;

namespace Code.DataAcces.DbContext;


public static class DbContext
{
    public static List<Employee> Employees { get; set; } = new();
    public static List<Department> Departments { get; set; } = new();
    public static List<CompanyType> Companys { get; set; } = new();
}
