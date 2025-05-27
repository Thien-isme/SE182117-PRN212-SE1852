void doicho(ref int a,ref int b)
{
    int c = a;
    a = b;
    b=c;

    Console.WriteLine("a TRONG khi vao ham = " + a);
    Console.WriteLine("b TRONG khi vao ham = " + b);
}

int a;
int b = 7;


Console.WriteLine("a TRUOC khi vao ham = " + a);
Console.WriteLine("b TRUOC khi vao ham = " + b);
doicho(ref a,ref b);

Console.WriteLine("a SAU khi vao ham = " + a);
Console.WriteLine("b SAU khi vao ham = " + b);


