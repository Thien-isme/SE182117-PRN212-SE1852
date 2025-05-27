//Ung dung Generic de quan li Nhan Vien
//Thuc hien cac thao tac CRUD
// C: Create
// R: Read (Retrieve)

// Cau 1: Tao 4 fulltime 1 partime
using OOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    Name = "Name 1",
    IdCard = "123",
    Birthday = new DateTime(1980, 1, 1)
};
employees.Add(fe1);

FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    Name = "Name 2",
    IdCard = "123",
    Birthday = new DateTime(1982, 1, 1)
};
employees.Add(fe2);

FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    Name = "Name 3",
    IdCard = "123",
    Birthday = new DateTime(1984, 1, 1)
};
employees.Add(fe3);

FulltimeEmployee fe4 = new FulltimeEmployee()
{
    Id = 4,
    Name = "Name 4",
    IdCard = "123",
    Birthday = new DateTime(1986, 1, 1)
};
employees.Add(fe4);

ParttimeEmployee fe5 = new ParttimeEmployee()
{
    Id = 5,
    Name = "Name 5",
    IdCard = "123",
    Birthday = new DateTime(1988, 1, 1),
    WorkingHour = 5
};
employees.Add(fe5);


// Cau 2: Xuat toan bo thong tin nhan su
// cach 1: dung expression body (Lamba Expression)
Console.WriteLine("Thong tin toan bo nhan su: ");
employees.ForEach(e => Console.WriteLine(e.ToString()));

// Cau 3 sap xep NV theo nam sinh tang dan
for(int i =0; i< employees.Count; i++)
{
    for(int j = 0; j < employees.Count; j++)
    {
        Employee ei = employees[i];
          Employee ej = employees[j];
        if(ei.Birthday < ej.Birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
        }
    }
}

Console.WriteLine("Sap xep tang dan theo nam: ");
employees.ForEach(e => Console.WriteLine(e.ToString()));

// Bai tap
// Bổ sung chức năng SỬA thông tin Nhân viên
Console.WriteLine("Nhap id NV can sua thong tin");
int idNVCanSua = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap ten moi");
string tenMoi = Console.ReadLine();
Console.WriteLine("Nhap idCardMoi moi");
string idCardMoi = Console.ReadLine();
Console.WriteLine("Nhap nam sinh moi (dd/MM/yyyy): ");
string birthdayMoi = Console.ReadLine();

 
if (DateTime.TryParseExact(birthdayMoi, "dd/MM/yyyy",
    System.Globalization.CultureInfo.InvariantCulture,
    System.Globalization.DateTimeStyles.None, out DateTime birthday))
{
    for(int i  =0; i< employees.Count; i++)
    {
        if (employees[i].Id == idNVCanSua)
        {
            employees[i].Name = tenMoi;
            employees[i].IdCard = idCardMoi;
            employees[i].Birthday = birthday;
        }
    }
            
}
else
{
    Console.WriteLine("Vui long nhap ngay sinh dung dinh dang dd/MM/yyyy.");
  
}

Console.WriteLine();

Console.WriteLine("Danh sach NV sau khi chinh sua ");
employees.ForEach(e => Console.WriteLine(e.ToString()));

// Bổ sung chức năng Xóa thông tin nhân viên
Console.WriteLine("Nhap id NhanVien can xoa");
int idNVCanXoa = int.Parse(Console.ReadLine());

for(int i = 0;i< employees.Count; i++)
{
    if (employees[i].Id == idNVCanXoa)
    {
        employees.RemoveAt(i);
    }
}
Console.WriteLine("Danh sach NV sau khi xoa ");
employees.ForEach(e => Console.WriteLine(e.ToString()));


Console.ReadLine();





