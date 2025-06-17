using DemoMyStoreLINQ2SQL;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = "server=LAPTOP-1D6UIU9P;database=MyStore;uid=sa;pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);

var categories = context.Categories;
foreach (var category in categories)
{
    Console.WriteLine(category.CategoryID+"\t"+category.CategoryName);
}

// Tim chi tiet 1 danh muc khi biet CategoryId
int cateid = 5;
Category cate = context.Categories.FirstOrDefault(c=> c.CategoryID==cateid);
if(cate == null)
{
    Console.WriteLine($"Khong tim thay cateid = {cateid}");
}
else
{
    Console.WriteLine($"Tim thay cateid = {cateid}");
    Console.WriteLine(cate.CategoryID + "\t" + cate.CategoryName);
}


// Them moi
//Category cnew = new Category();
//cnew.CategoryName = "Thien";
//context.Categories.InsertOnSubmit(cnew);
//context.SubmitChanges();

// Them moi nhieu danh muc
/*List<Category> danhSachDanhMucMoi = new List<Category>();
danhSachDanhMucMoi.Add(new Category() { CategoryName = "Latop" });
danhSachDanhMucMoi.Add(new Category() { CategoryName = "TV" });
danhSachDanhMucMoi.Add(new Category() { CategoryName = "Phu kien" });

context.Categories.InsertAllOnSubmit(danhSachDanhMucMoi);
context.SubmitChanges();*/

// Cau 5 Sua ten danh muc
Category c = (from x in context.Categories
             where x.CategoryID == 10
             select x).FirstOrDefault();

Category c2 = context.Categories.FirstOrDefault(x => x.CategoryID ==10);

if (c2 != null)
{
    c2.CategoryName = "Ret";
    context.SubmitChanges();
}

// Cau 6 xoa danh muc
Category c13 = context.Categories.FirstOrDefault(x=> x.CategoryID == 13);
if(c13 != null)
{
    context.Categories.DeleteOnSubmit(c13);
    context.SubmitChanges();
}

//// cau 7 xoa tat ca danh muc ma khong chua bat ky san pham nao
//Category cdelete = from Category join Product;
//context.Categories.DeleteOnSubmit(cdelete)
Console.WriteLine("gdgdf");
var list = from cat in context.Categories
                      join product in context.Products on cat.CategoryID equals product.CategoryID
                      select cat;

foreach (Category item in list.ToList())
{

Console.WriteLine(item.CategoryID);
}



