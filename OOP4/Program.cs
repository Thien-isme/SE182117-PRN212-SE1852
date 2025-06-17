// See https://aka.ms/new-console-template for more information

using OOP4;

Category laptop = new Category();
laptop.Id = 1;
laptop.Name = "Danh Muc Laptop";

Product dell1 = new Product()
{
    Id = 1,
    Name = "Dell-1",
    Quantity = 10,
    Price = 15000000
};

Product dell2 = new Product()
{
    Id = 2,
    Name = "Dell-2",
    Quantity = 5,
    Price = 40000000
};

Product lenovo = new Product()
{
    Id = 3,
    Name = "Lenovo",
    Quantity = 10,
    Price = 30000000
};

Product lenovo2 = new Product()
{
    Id = 4,
    Name = "Lenovo2",
    Quantity = 7,
    Price = 40000000
};

laptop.AddProduct(dell1);
laptop.AddProduct(dell2);
laptop.AddProduct(lenovo);
laptop.AddProduct(lenovo2);

laptop.PrintAllProducts();

// Test tim 1 Product
Console.WriteLine("Nhap id ma san pham can tim");
int id = int.Parse(Console.ReadLine());
Product p = laptop.GetProduct(id);
if(p == null)
{
    Console.WriteLine("Khong tim thay san pham co id ${0}",id);
}
else
{
    Console.WriteLine("Da tim thay san pham co id ${0}", id);
    Console.WriteLine(p);
}

// Test sort 1
Console.WriteLine("Danh sach TRUOC khi sap xep");
Dictionary<int, Product> sortedProducts =  laptop.SortProduct();
laptop.PrintAllProducts();

Console.WriteLine("Danh sach SAU khi sap xep");
foreach(KeyValuePair<int, Product> product in sortedProducts)
{

    Console.WriteLine(product.Value);
}

// Test sort 2
Console.WriteLine("Danh sach TRUOC khi sap xep");
Dictionary<int, Product> complexProducts = laptop.ComplexSort();
laptop.PrintAllProducts();

Console.WriteLine("Danh sach SAU khi sap xep");
foreach (KeyValuePair<int, Product> product in sortedProducts)
{

    Console.WriteLine(product.Value);
}


// Test Edit
Product px = new Product();
px.Id = 1;
px.Name = "MAC BOOK 1000";
px.Quantity = 80;
px.Price = 500;
Console.WriteLine("Danh sach san pham sau khi sua");
laptop.Edit(px);
laptop.PrintAllProducts();



// Test remove
int pid_remove = 1;
laptop.RemoveProduct(pid_remove);
Console.WriteLine("Danh sach san pham sau khi XOA");
laptop.PrintAllProducts();

















Console.ReadLine();









