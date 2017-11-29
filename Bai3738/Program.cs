using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3738
{
    class Program
    {
        public static void bai37(int[] a, int length)
        {
            for (int i = 1; i <= length / 2; i++)
            {
                if (a[i] != a[length - i + 1])
                {
                    Console.WriteLine("Khong phai mang doi xung");
                    return;
                }
            }
            Console.WriteLine("Mang doi xung !");
        }

        public static void bai38(int[] a, int length, int maxOfA)
        {
            int[] b = new int[maxOfA + 1];
            for (int i = 1; i <= length; i++)
            {
                b[a[i]]++;
            }

            int maxOfB = 0;
            int index = 0;
            for (int i = 1; i <= maxOfA; i++)
            {
                if (b[i] > maxOfB)
                {
                    index = i;
                    maxOfB = b[i];
                }
            }
            Console.WriteLine("Phan tu " + index + " xuat hien nhieu nhat : " + maxOfB + " lan");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so phan tu : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            int maxOfA = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nhap vao phan tu thu " + i + "\t");
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] > maxOfA) maxOfA = a[i];
            }
            bai37(a, n);
            bai38(a, n, maxOfA);
            Console.ReadKey();
        }
    }
}
