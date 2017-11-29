using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 1 số : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Kết quả : " + (input * (input + 1)) / 2);
            Console.ReadKey();
        }
    }
}
