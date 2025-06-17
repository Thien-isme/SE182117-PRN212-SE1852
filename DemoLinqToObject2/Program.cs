// See https://aka.ms/new-console-template for more information
using DemoLinqToObject2;

Console.OutputEncoding = System.Text.Encoding.UTF8;

ListProduct lp = new ListProduct();
// gia lap du lieu
lp.gen_sample_products();
Console.WriteLine("Danh sach Products:");
lp.PrintProducts();

Console.WriteLine("Danh sach san pham co gia tu 80 -> 100");
lp.FilterProductByPrice(80, 100);

Console.WriteLine("Danh sach san pham co gia tu ? -> ? tang dan");
lp.FilterProductByPriceAsc(0, 10000);

Console.WriteLine("Loc danh sach san pham theo Quantity");
lp.FilterProductByQuantity(0, 10000);


Console.ReadLine();
















