StudentService studentService = new StudentService();
GroupService groupService = new GroupService();
GroupTypeService groupTypeService = new GroupTypeService();
//Console.WriteLine("Programming:");
groupTypeService.Create("Programming");
//Console.WriteLine("Design:");
groupTypeService.Create("Design");

Console.WriteLine("get all types:");
foreach (var type in groupTypeService.GetAll())
{
    Console.WriteLine(type.Type);
}

Console.WriteLine("Create group:");
Console.WriteLine("1:");
groupService.Create("P137", "Programming", 2);
Console.WriteLine("2:");
groupService.Create("P138", "Programming", 2);
Console.WriteLine("get all groups:");
foreach (var group in groupService.GetAll())
{
    Console.WriteLine(group.GroupName);
}


Console.WriteLine("Create student:");
EmployeCreateDto s1 = new("Adil", "Tehranli", "P138");
StudentCreateDto s2 = new("Kenan", "Qehremanov", "P138");
StudentCreateDto s3 = new("Samid", "Saitli", "P137");
Console.WriteLine("1:");
studentService.Create(s1);
Console.WriteLine("2:");
studentService.Create(s2);
Console.WriteLine("3:");
studentService.Create(s3);
Console.WriteLine("get all students:");
foreach (var stu in studentService.GetAll(3, 2))
{
    Console.WriteLine(stu.Name);
}