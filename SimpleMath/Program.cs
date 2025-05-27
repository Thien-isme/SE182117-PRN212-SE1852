public class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Nhap so a ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so b ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap phep toan ");
        string op = Console.ReadLine();

        string result = Program.do_math(a,b,op);
        Console.WriteLine(result);

        Console.ReadLine();
    }

    static string do_math(double a, double b, string op)
    {
        string result = "";
        switch (op)
        {
            case "+":
                result = a + "+" + b + "=" + (a + b);
                break;
            case "-":
                result = a + "-" + b + "=" + (a - b);
                break;
            case "*":
                result = a + "*" + b + "=" + (a * b);
                break;
            case "/":
                result = a + "/" + b + "=" + (a / b);
                break;
            default:
                result = "Nhap sai";
                break;
        }


        return result;
    }





}