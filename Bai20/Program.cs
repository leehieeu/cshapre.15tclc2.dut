using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a  b  c");
            for (int b = 0; b <= 30; b++)
            {
                for (int c = 0; c <= 30; c++)
                {
                    double a = Math.Sqrt(b * b + c * c);
                    if (a == (int)a && a <= 30)
                        Console.WriteLine(a + "  " + b + "  " + c);
                }
            }
            Console.ReadKey();
        }
    }
}
