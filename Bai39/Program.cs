using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai39den47
{
    class Program
    {
        public static bool checkPrime(int n)
        {
            if (n == 2) return true;
            else if (n == 0 || n == 1 || n % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(n); i = i + 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static void hoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void bai39(int[] array, int length)
        {
            Console.WriteLine("\nCac phan tu cua mang : ");
            for (int i = 1; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void bai40(ref int[] array, int length)
        {
            for (int i = 1; i <= length - 1; i++)
            {
                for (int j = 0; j <= length - i - 1; j++)
                {
                    if (array[j] > array[j + 1]) hoanVi(ref array[j], ref array[j + 1]);
                }
            }
        }

        public static void bai41(int[] array, int length)
        {
            long sum = 0;
            for (int i = 1; i < length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Tong la : " + sum);
        }

        public static void bai42(int[] array, int length)
        {
            Console.WriteLine("\nCac phan tu cua mang : ");
            for (int i = 1; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void bai43(int[] array, int length)
        {
            long sum = 0;
            for (int i = 1; i < length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Tong la : " + sum);
        }

        public static void bai44(int[] array, int length)
        {
            long res1 = 1;
            long res2 = 1;
            for (int i = 1; i < length; i++)
            {

                if (array[i] % 2 == 0) res1 *= array[i];
                if (i % 2 != 0) res2 *= array[i];
            }
            Console.WriteLine("Tich cac chu so chan : " + res1);
            Console.WriteLine("Tich cac so o vi tri le : " + res2);
        }

        public static void bai45(ref int[] a, int length)
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
        }

        public static void bai46(int[] a, int length)
        {
            Console.Write("Nhap vao vi tri : ");
            int pos = int.Parse(Console.ReadLine());
            int chosen = a[pos];
            Console.WriteLine("Vua chon phan tu : " + chosen);
            Array.Sort(a);

            Console.WriteLine("Cac so nguyen nho hon la : ");
            for (int i = 1; i <= length; i++)
            {
                if (a[i] == chosen) break;
                else
                {
                    if (checkPrime(a[i])) Console.WriteLine(a[i] + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 day so nguyen : ");
            string input = Console.ReadLine();
            string[] a;
            a = input.Split(new String[] { " ", "  ", "   " }, StringSplitOptions.RemoveEmptyEntries);

            int length = a.Length + 1;
            int[] array = new int[length];
            for (int i = 0; i < length - 1; i++)
            {
                array[i + 1] = int.Parse(a[i]);
            }
            bai39(array, length);
            //bai40(ref array, length);
            //bai41(array, length);
            //bai44(array, length);
            //bai45(ref array, length);
            bai46(array, length);
            Console.ReadKey();
        }
    }
}
