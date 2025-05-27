// See https://aka.ms/new-console-template for more information
using OOP2;
using OOP2_Reuse_as_Library;

Console.WriteLine("Hello, World!");
FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Teo"; 
e1.Birthday = new DateTime(1960,1,1);
Console.WriteLine("Age: " + e1.TinhTuoi());