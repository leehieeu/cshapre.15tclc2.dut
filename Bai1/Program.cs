using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập 1 số : ");
            int input = int.Parse(Console.ReadLine());
            if (input % 2 == 0) Console.WriteLine("Số chẵn");
            else Console.WriteLine("Số lẻ");
            Console.ReadKey();
        }
    }
}
