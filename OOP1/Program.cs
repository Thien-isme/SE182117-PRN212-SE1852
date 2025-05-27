using OOP1;
using System.Collections.Concurrent;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nuoc";

Console.WriteLine(c1.PrintInfor);

Employee employee = new Employee();

Employee employee2 = new Employee(1, "Thien","thienis", "65661");

Console.WriteLine(employee2.ToString());

Employee employee1 = new Employee()
{
    ID = 1,
    Email = "Thien",
    Name = "Thien",
    Phone = "fdf"
};
Console.WriteLine(employee1.ToString());






