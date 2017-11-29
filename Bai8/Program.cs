using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào số nguyên : ");
            int input = int.Parse(Console.ReadLine());
            String s = "";
            while (input > 0)
            {
                s = input % 2 + s;
                input = input / 2;
            }
            Console.WriteLine("Dạng nhị phân : " + s);
            Console.ReadKey();
        }
    }
}
