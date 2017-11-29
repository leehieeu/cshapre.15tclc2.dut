using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 1 chuỗi : ");
            string input = Console.ReadLine();
            string[] res;
            res = input.Split();
            for (int i = 0; i <= res.Length - 1; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
