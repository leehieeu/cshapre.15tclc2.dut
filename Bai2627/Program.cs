using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2627
{
    class Program
    {
        public static long findSum(int[] a)
        {
            long res = 0;
            for (int i = 1; i <= a.Length - 1; i++)
            {
                res += a[i];
            }
            return res;
        }

        public static int findMax(int[] a)
        {
            int max = a[0];
            for (int i = 1; i <= a.Length - 1; i++)
            {
                if (max < a[i]) max = a[i];
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so phan tu : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nhap vao phan tu thu" + i + "\t");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Thuc hien ham tinh tong\nKet qua la : ");
            Console.WriteLine(findSum(a));
            Console.Write("Thuc hien ham tim Max\nKet qua la : ");
            Console.WriteLine(findMax(a));
            Console.ReadKey();
        }
    }
}
