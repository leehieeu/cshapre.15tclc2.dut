using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so phan tu : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            long res1 = 1; long res2 = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nhap vao phan tu thu " + i + "\t");
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] % 2 == 0) res1 *= a[i];
                if (i % 2 != 0) res2 *= a[i];
            }
            Console.WriteLine("Tich cac chu so chan : " + res1);
            Console.WriteLine("Tich cac so o vi tri le : " + res2);
            Console.ReadKey();
        }
    }
}
