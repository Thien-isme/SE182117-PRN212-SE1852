
using LucyDemoLINQ2SQL;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = "server=LAPTOP-1D6UIU9P;database=Lucy_SalesData;uid=sa;pwd=12345";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);

// Xuat danh sach KH co mua hang
var ds1 = from c in context.Customers
          where c.Orders.Count() > 0
          select c;

Console.WriteLine("Danh sach khach hang co mua hang");
foreach (var c in ds1)
{
    Console.WriteLine(c.CustomerID+"\t"+c.ContactName);
}

// Loc ra top 3 KH mua hang co so tien nhieu nhat
var list = (from c in context.Customers
                       join o in context.Orders on c.CustomerID equals o.CustomerID
                       join od in context.Order_Details on o.OrderID equals od.OrderID
                       group new { od } by c.CustomerID into g
                       let total = g.Sum(x => x.od.Quantity * x.od.UnitPrice*x.od.Discount)
                       orderby total descending
                       select new
                       {
                           CustomerID = g.Key,
                           TotalAmount = total
                       }).Take(3).ToList();


foreach (var c in list)
{
    Console.WriteLine(c.CustomerID+"\t"+ c.TotalAmount);
}



Console.ReadLine();










