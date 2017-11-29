using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai45
{
    class Program
    {
        static int[] a;
        static int length;

        public static void nhapMang()
        {
            Console.WriteLine("Nhap vao so phan tu : ");
            int n = int.Parse(Console.ReadLine());
            length = n;
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap vao phan tu thu " + (i + 1) + "\t");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void xuatMang()
        {
            Console.WriteLine("Cac phan tu cua mang : ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }

        public static int[] sapXep()
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 1; j < length; j++)
                {
                    if (a[i] > a[j]) hoanVi(ref a[i], ref a[j]);
                }
            }
            return a;
        }

        public static int[] sapXepMaiNgoi()
        {
            int max = a[0];
            int index = 0;
            for (int i = 1; i < length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                    index = i;
                }
            }

            hoanVi(ref a[index], ref a[length / 2]);

            for (int i = 0; i < length / 2 - 1; i++)
            {
                for (int j = i + 1; j < length / 2; j++)
                {
                    if (a[i] > a[j]) hoanVi(ref a[i], ref a[j]);
                }
            }

            for (int i = length / 2 + 1; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (a[i] < a[j]) hoanVi(ref a[i], ref a[j]);
                }
            }
            return a;
        }

        public static int[] sxmn()
        {
            int max = a[0];
            int index = 0;
            for (int i = 1; i < length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                    index = i;
                }
            }

            hoanVi(ref a[index], ref a[length / 2]);

            Array.Sort(a, 0, length / 2);
            Array.Sort(a, length / 2 + 1, length / 2);
            Array.Reverse(a, length / 2 + 1, length / 2);
            return a;
        }


        public static void hoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            nhapMang();
            xuatMang();
            a = sxmn();
            xuatMang();

            Console.ReadKey();
        }
    }
}
