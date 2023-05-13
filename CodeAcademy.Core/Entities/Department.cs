﻿using CodeAcademy.Core.Interfaces;

namespace CodeAcademy.Core.Entities;

public class Department:IEntity
{
    private static int _id;
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    public static int CompanyId { get; set; }
    public int DepartmentId { get;}
    public Department()
    {
        DepartmentId =_id;
        _id++;

    }
    public Department(string name):this()
    {
        Name = name;
    }
    public override string ToString()
    {
        return $"name{Name} Id:{DepartmentId}";
    }
}
