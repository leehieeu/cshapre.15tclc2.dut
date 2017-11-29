using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào nhiệt độ C : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhiệt độ F là : " + String.Format("{0:0.00}", n * 1.8 + 32) +" °F");
            Console.ReadKey();
        }
    }
}
