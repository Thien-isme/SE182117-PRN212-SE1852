internal class Program
{
    public delegate int[] MyDelegate(int n);
    static public int[] ListEven(int n)
    {
        List<int> ints = new List<int>();
        for (int i = 0; i < n; i=i+2)
        {
            ints.Add(i);

        }
        return ints.ToArray();
    }

    static public int[] ListPrime(int n)
    {
        List<int> ints = new List<int>();
        for (int i = 2; i < n; i++)
        {
            int count = 0;
            for(int j = 1; j < n; j++)
            {
                if (i%j==0)
                    count++;
            }

            if (count == 2)
            {
                ints.Add(i);
            }

        }
        return ints.ToArray();
    }
    private static void Main(string[] args)
    {
        MyDelegate d1 = new MyDelegate(ListEven);
        int[] result = d1(10);

        Console.WriteLine("Cac so chan");
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

        MyDelegate d2 = new MyDelegate(ListPrime);
        int[] listPrime = d2(10);
        Console.WriteLine("Cac so Nguyen to");
        for (int i = 0; i < listPrime.Length; i++)
        {
            Console.WriteLine(listPrime[i]);
        }





        Console.ReadLine();

    }
}


