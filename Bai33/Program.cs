using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai33
{
    class Program
    {
        public static int[] chenVaoMang(ref int[] a)
        {

            Console.WriteLine("Nhap vao phan tu can chen : ");
            int element = int.Parse(Console.ReadLine());
            int index = 0;
            Console.WriteLine("Nhap vao vi tri can chen :");
            index = int.Parse(Console.ReadLine());

            while (index > a.Length)
            {
                Console.WriteLine("Nhap lai vi tri can chen nho hon kich thuoc mang : ");
                index = int.Parse(Console.ReadLine());
            }

            int[] temp = new int[a.Length + 1];
            Array.Copy(a, 1, temp, 1, index - 1);
            temp[index] = element;
            Array.Copy(a, index, temp, index + 1, a.Length - index);
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

            int[] resArr = chenVaoMang(ref a);
            for (int i = 1; i <= n + 1; i++)
            {
                Console.Write(resArr[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}
