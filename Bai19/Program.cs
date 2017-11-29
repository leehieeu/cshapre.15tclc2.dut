using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 1 số : ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 400 != 0) Console.WriteLine("Năm nhuận");
            else Console.WriteLine("Năm không nhuận");
            Console.ReadKey();
        }
    }
}
