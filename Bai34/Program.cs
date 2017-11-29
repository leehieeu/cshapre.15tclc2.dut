using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai34
{
    class Program
    {
        public static int[] evenFirst(int[] a)
        {
            Array.Sort(a);
            int[] temp = new int[a.Length];
            bool[] check = new bool[+1];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] % 2 == 0) check[i] = true;
            }

            int index = 1;
            for (int i = 1; i < a.Length; i++)
            {
                if (check[i])
                {
                    temp[index] = a[i];
                    index++;
                }
            }

            for (int i = 1; i < a.Length; i++)
            {
                if (!check[i])
                {
                    temp[index] = a[i];
                    index++;
                }
            }

            return temp;
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

            a = evenFirst(a);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}
