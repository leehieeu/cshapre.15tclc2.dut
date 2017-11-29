using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai35
{
    class Program
    {
        static int[] a;
        public static void nhapMang()
        {
            Console.WriteLine("Nhap vao so phan tu : ");
            int n = int.Parse(Console.ReadLine());
            a = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nhap vao phan tu thu " + i + "\t");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public static int[] xoaPhanTu(int index)
        {
            int[] temp = new int[a.Length - 1];

            for (int i = 1; i < index; i++)
            {
                temp[i] = a[i];
            }
            for (int i = index; i < a.Length - 1; i++)
            {
                temp[i] = a[i + 1];
            }

            return temp;
        }

        static void Main(string[] args)
        {
            nhapMang();
            int index;
            Console.WriteLine("Nhap vao vi tri can xoa : ");
            index = int.Parse(Console.ReadLine());
            while (index > a.Length)
            {
                Console.WriteLine("Nhap lai vi tri can xoa : ");
                index = int.Parse(Console.ReadLine());
            }
            a = xoaPhanTu(index);
            for (int i = 1; i < a.Length; i++)
            {
                Console.Write(a[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}
