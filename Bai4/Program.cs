using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Điểm hệ số : ");
            float input = float.Parse(Console.ReadLine());
            if (input <= 3.9) Console.WriteLine("Điểm hệ chữ : F");
            else if (input <= 5.4) Console.WriteLine("Điểm hệ chữ : D");
            else if (input <= 6.4) Console.WriteLine("Điểm hệ chữ : C");
            else if (input <= 8) Console.WriteLine("Điểm hệ chữ : B");
            else if (input <= 10) Console.WriteLine("Điểm hệ chữ : A");
            Console.ReadKey();
        }
    }
}
