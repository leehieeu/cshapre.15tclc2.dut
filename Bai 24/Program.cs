using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 1 chuỗi : ");
            string input = Console.ReadLine();
            char[] a = input.ToCharArray();
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] >= 65 && a[i] <= 90)
                    Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
