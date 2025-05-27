using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string ho = "Lai";
        string ten = "Thien";
        String tenfull = ho +" "+ ten;
        Console.WriteLine(tenfull);

        StringBuilder sb = new StringBuilder();
        sb.Append(ho);
        sb.Append(" "); 
        sb.Append(ten);
        string tenfull2 = sb.ToString();
        Console.WriteLine(tenfull2);


        Console.ReadLine();
    }
}