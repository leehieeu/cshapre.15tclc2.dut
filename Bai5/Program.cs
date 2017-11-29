using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào a : ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào b : ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào c : ");
            float c = float.Parse(Console.ReadLine());
            float d;
            d = (a > b) ? a : b;
            Console.WriteLine("Số lớn nhất là : " + ((d > c) ? d : c));
            Console.ReadKey();
        }
    }
}
