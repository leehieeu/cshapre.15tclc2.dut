using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so Dollar $ : ");
            int money = int.Parse(Console.ReadLine());
            Console.WriteLine("So tien VND la : " + money * 22000);
            Console.ReadKey();
        }
    }
}
