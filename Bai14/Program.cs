using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 1 số : ");
            int input = int.Parse(Console.ReadLine());
            long res = 0;
            for (int i = 2; i <= input; i++)
            {
                res = res + i * (i - 1);
            }
            Console.WriteLine("Kết quả là : " + res);
            Console.ReadKey();
        }
    }
}
