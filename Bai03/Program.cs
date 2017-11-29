using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào số đo độ : ");
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine("Số đo radian là : " + String.Format("{0:0.00}", (temp * Math.PI / 180))+ " radian");
            Console.ReadKey();
        }
    }
}
