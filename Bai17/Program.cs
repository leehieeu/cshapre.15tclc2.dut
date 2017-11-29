using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    class Program
    {
        public static void doiCho(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 2 số a và b : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            doiCho(ref a, ref b);
            Console.WriteLine("a = " + a + "\tb = " + b);
            Console.ReadKey();
        }
    }
}
