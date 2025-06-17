internal class Program
{
    private static void Main(string[] args)
    {
        //Dung LinqToObject de xuat cac so chan trong object
        int[] arr = { 100, 35, 80, 17, 22, 40, 70 };

        // Cach1: Dung method Syntax (Extension method)
        var even_list = arr.Where(x=> x % 2 == 0);

        Console.WriteLine("Danh sach cac so chan theo method Syntax");
        foreach(var x in even_list)
        {
            Console.Write(x+"\t");
        }

        // Cach 2: dung query Syntax (Cu phap tuong tu SQL)
        var even_list2 = from x in arr
                         where x % 2 == 0
                         select x;
        Console.WriteLine("Danh sach cac so chan theo Query Syntax");
        foreach (var x in even_list2)
        {
            Console.Write(x + "\t");
        }

        // Sap xep mang tang dan va giam dan dung Method va Query syntax
        // Dung Method
        var list_asc = arr.OrderBy(x => x);
        var list_desc = arr.OrderByDescending(x => x);

        // Dung Query
        var list_asc2 = from x in arr
                        orderby x
                        select x;
        var list_des2 = from x in arr
                        orderby x descending
                        select x;

        // Duyet de xem
        Console.WriteLine("Danh sach tang dan");
        foreach (var x in list_asc)
        {
            Console.Write(x + "\t");
        }



        // Tinh tong danh sach
        Console.WriteLine("Tong ="+arr.Sum());


        Console.ReadLine();
    }
}