using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so phan tu : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Nhap vao phan tu thu " + i + "\t");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cac so chan ");
            for (int i = 1; i <= n; i++)
            {
                if (a[i] % 2 == 0) Console.Write(a[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
