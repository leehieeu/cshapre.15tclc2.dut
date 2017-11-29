using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 1 chuỗi : ");
            string input = Console.ReadLine();
            char[] a = input.ToCharArray();
            for (int i = 1; i <= a.Length - 1; i++)
            {
                if (a[i] != ' ' && a[i - 1] == ' ')
                {
                    a[i] = char.ToUpper(a[i]);
                }
            }
            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.Write(a[i]);
            }
            Console.ReadKey();
        }
    }
}
