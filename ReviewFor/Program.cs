
int n;
do
{

Console.WriteLine("Nhap n > =0");
string s = Console.ReadLine();

    if (int.TryParse(s, out n) == false)
    {
        Console.WriteLine("Ban phai nhap so");

    }
    else
    {
        if (n < 0)
        {
            Console.WriteLine("Phai nhap n > 0");
        }
        else
        {
            int giaithua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaithua *= i;
            }
            Console.WriteLine("giai thua cua {0} = {1}", n, giaithua);
        }
    }
} while (n<=0);






    
