using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 1 số : ");
            int input = int.Parse(Console.ReadLine());
            double res = 0;
            for (int i =1; i<=input; i= i+2)
            {
                res += (Math.Pow(-1, (i - 1)/2)) / i;
            }
            Console.WriteLine("Kết quả là : " + (4 * res));
            Console.ReadKey();
        }
    }
}
