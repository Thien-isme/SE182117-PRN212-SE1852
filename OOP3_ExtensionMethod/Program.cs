// See https://aka.ms/new-console-template for more information
using OOP3_ExtensionMethod;

Console.OutputEncoding = System.Text.Encoding.UTF8;

int n1 = 5;
int n2 = 10;

Console.WriteLine("Tong n1: {0}", n1.TongTu1ToiN());


int[] M = new int[10];
Random random = new Random();

M.TaoMangNgauNhien();
Console.WriteLine("Mang truoc khi sap xep");
M.XuatMang();
M.sapXepTangDan();
Console.WriteLine("Mang sau khi sap xep");
M.XuatMang();



















