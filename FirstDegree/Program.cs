// See https://aka.ms/new-console-template for more information
Console.WriteLine("Phuong trinh bac 1");
Console.WriteLine("Nhap a: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Nhap b: ");
double b = double.Parse(Console.ReadLine());

if(a==0 && b==0)
{
    Console.WriteLine("Phuong trinh co vo so nghiem");
}
else if(a==0 && b!=0)
{
    Console.WriteLine("Phuong trinh vo nghiem");
}
else
{
    double x = -b/a;
    Console.WriteLine($"Phuong trinh co 1 nghiem: x = {x}");
}




Console.ReadLine(); 
