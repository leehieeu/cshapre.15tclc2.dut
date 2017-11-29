using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào hệ số a : ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào hệ số b : ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào hệ số c : ");
            float c = float.Parse(Console.ReadLine());

            if (a + b <= c || a + c <= b || b + c <= a) Console.WriteLine("Không phải tam giác");
            else Console.WriteLine("Là tam giác");
            Console.ReadKey();
        }
    }
}
