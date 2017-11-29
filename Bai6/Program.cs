using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào số dòng : ");
            int input = int.Parse(Console.ReadLine());
            int limit = 2 * input;
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= limit+i; j++)
                {
                    if (j > limit - i && j < limit+i) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
