// See https://aka.ms/new-console-template for more information

void giai_bac_1(double a, double b)
{
    if (a == 0 && b == 0)
    {
        Console.WriteLine("Phuong trinh co vo so nghiem");
    }
    else if (a == 0 && b != 0)
    {
        Console.WriteLine("Phuong trinh vo nghiem");
    }
    else
    {
        double x = -b / a;
        Console.WriteLine($"Phuong trinh co 1 nghiem: x = {x}");
    }
}

void giai_bac_2(double a, double b, double c)
{
    if (a == 0)
    {
        giai_bac_1(b, c);
    }
    else
    {
        double delta = b * b - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Phuong trinh co 1 nghiem: x = {x}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Phuong trinh co 2 nghiem: x1 = {x1}, x2 = {x2}");
        }
    }
}




Console.WriteLine("nhap a");
var a = Console.ReadLine();
Console.WriteLine("nhap b");
var b = Console.ReadLine();
Console.WriteLine("nhap c");
giai_bac_1(double.Parse(a), double.Parse(b));


var c = Console.ReadLine();













