using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    class Program
    {
        public static long nFibo(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                long preFib = 1;
                long curFib = 1;
                long nextFib = 2;
                int index = 2;
                while (index < n)
                {
                    nextFib = curFib + preFib;
                    preFib = curFib;
                    curFib = nextFib;
                    index++;
                }
                return nextFib;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào số n : ");
            int n = int.Parse(Console.ReadLine());
            long res = nFibo(n);
            Console.WriteLine("Kết quả là : " + res);
            Console.ReadKey();
        }
    }
}
