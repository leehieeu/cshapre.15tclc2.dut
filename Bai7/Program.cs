using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        public static int UCLN(int a, int b)
        {
            if (a == b) return a;
            else if (a > b) return UCLN(a - b, b);
            else return UCLN(a, b - a);
        }

        public static int BCNN (int a, int b)
        {
            return a * b / UCLN(a, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 2 số : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("UCLN : " + UCLN(a, b));
            Console.WriteLine("BCNN : " + BCNN(a, b));
            Console.ReadKey();

        }
    }
}
