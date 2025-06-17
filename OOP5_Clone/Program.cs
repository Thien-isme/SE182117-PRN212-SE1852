using OOP5_Clone;

Product p1 = new Product() { Id = 1, Name = "Coca", Quantity = 10, Price = 100 };

Product p2 = new Product() { Id = 2, Name = "Pepsi", Quantity = 10, Price = 100 };

p1 = p2;

p2.Price = 123;
p2.Name = "Sting";

Console.WriteLine(p2.Name);
Console.ReadLine();

Product p3 = new Product() { Id = 3, Name = "C2", Quantity = 10, Price = 100 };
Product p4 = new Product() { Id = 4, Name = "Pepsi", Quantity = 10, Price = 100 };
Product p5 = new Product() { Id = 5, Name = "Coca", Quantity = 10, Price = 100 };
p5 = p3;
p3 = p4;
// p3 không bị thu hồi ô nhớ, ô nhớ đó đang được p5 quản lí



Product p6 = new Product() { Id = 6, Name = "P6", Quantity = 10, Price = 100 };
Product p7 = p6.clone();

// p6, p7 là có 2 giá trị khác nhau nằm trên 2 ô nhớ khác nhau
p7.Name = "Thien";
Console.WriteLine("----------P6---------");
Console.WriteLine(p6.Name);
Console.WriteLine("----------P7---------");
Console.WriteLine(p7.Name);






