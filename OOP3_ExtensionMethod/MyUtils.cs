using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_ExtensionMethod
{
    public static class MyUtils
    {
        //Cai dat ham tinh tong tu 1 -> N
        // vao kieu int cua Microsoft

        public static int TongTu1ToiN(this int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        public static void sapXepTangDan(this int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; i < arr.Length-i-1; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void TaoMangNgauNhien(this int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(101);
            }

        }

        public static void XuatMang(this int[] arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine(i+"\t");
            }
            Console.WriteLine();
        }


    }
}
