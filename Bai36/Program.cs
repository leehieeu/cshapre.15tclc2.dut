using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai36
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

        public static int[] chenPhanTu(int element)
        {
            Array.Sort(a);
            int[] temp = new int[a.Length + 1];
            int index = a.Length;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] >= element)
                {
                    temp[i] = element;
                    index = i;
                    break;
                }
                else temp[i] = a[i];
            }
            for (int i = index + 1; i <= a.Length; i++)
            {
                temp[i] = a[i - 1];
            }
            return temp;
        }

        static void Main(string[] args)
        {
            nhapMang();

            for (int i = 1; i <= a.Length - 1; i++)
            {
                Console.Write(a[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Nhap vao phan tu can chen :");
            int element = int.Parse(Console.ReadLine());

            a = chenPhanTu(element);
            for (int i = 1; i <= a.Length - 1; i++)
            {
                Console.Write(a[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}
