using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai29
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
            Array.Sort(a);
            Array.Reverse(a);
            Console.WriteLine("Mang sau khi sap xep giam dan ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.ReadKey();

        }
    }
}
