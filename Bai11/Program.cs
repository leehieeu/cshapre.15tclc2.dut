using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    class Program
    {
        public static bool checkPrime(int input)
        {
            if (input == 0 || input == 1) return false;
            else if (input == 2 || input == 3) return true;
            else if (input % 2 == 0) return false;
            else
            {
                for (int i = 3; i <= Math.Sqrt(input); i = i + 2)
                {
                    if (input % i == 0) return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 1 số : ");
            int input = int.Parse(Console.ReadLine());
            if (checkPrime(input)) Console.WriteLine("Số nguyên tố");
            else Console.WriteLine("Không phải số nguyên tố");
            Console.ReadKey();
        }
    }
}
