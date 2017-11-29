using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào n : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào x : ");
            int x = int.Parse(Console.ReadLine());
            double res = 0;
            int index = 1;
            long MS = 1;
            while (index <= n)
            {
                res += (Math.Pow(x, index)) / (MS * index);
                index++;
            }
            Console.WriteLine("Kết quả là : " + res);
            Console.ReadKey();
        }
    }
}
