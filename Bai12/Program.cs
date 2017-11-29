using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào số để tính giai thừa : ");
            int input = int.Parse(Console.ReadLine());
            long res = 1;
            for (int i = 2; i <= input; i++)
                res *= i;
            Console.WriteLine("Kết quả là : " + res);
            Console.ReadKey();
        }
    }
}
