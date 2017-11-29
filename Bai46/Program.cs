﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4647
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
        public static void execute(int[] a, int length)
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
            Console.WriteLine("Nhap vao so phan tu : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nhap vao phan tu thu " + i + "\t");
                a[i] = int.Parse(Console.ReadLine());
            }

            execute(a, n);
            Console.ReadKey();
        }
    }
}
