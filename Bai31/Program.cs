using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai31
{
    class Program
    {
        static int[] resArr;
        static int n, m;
        public static void noiMang(int[] a, int[] b)
        {
            resArr = new int[n + m + 1];
            for (int i = 1; i <= n; i++)
            {
                resArr[i] = a[i];
            }
            for (int i = 1; i <= m; i++)
            {
                resArr[n + i] = b[i];
            }


            Console.WriteLine("Mang sau khi nhap la : ");
            for (int i = 1; i <= n + m; i++)
            {
                Console.Write(resArr[i] + "  ");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so phan tu : ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nhap vao phan tu thu " + i + "\t");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("Nhap vao so phan tu : ");
            m = int.Parse(Console.ReadLine());
            int[] b = new int[m + 1];
            for (int i = 1; i <= m; i++)
            {
                Console.Write("Nhap vao phan tu thu " + i + "\t");
                b[i] = int.Parse(Console.ReadLine());
            }

            noiMang(a, b);
            Console.ReadKey();
        }
    }
}
