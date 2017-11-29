using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai30
{
    class Program
    {

        public static int findElement(int x, int[] a)
        {
            for (int i = 1; i <= a.Length - 1; i++)
            {
                if (x == a[i])
                    return i;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so phan tu : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nhap vao phan tu thu " + i + "\t");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nhap vao phan tu can tim : ");
            int x = int.Parse(Console.ReadLine());
            int res = findElement(x, a);
            Console.WriteLine("Vi tri tim thay : " + res);
            Console.ReadKey();

        }
    }
}
