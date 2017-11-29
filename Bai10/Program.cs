using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 1 số : ");
            int input = int.Parse(Console.ReadLine());
            string s = input.ToString();
            for (int i=s.Length-1;i>=0;i--)
            {
                Console.Write(s[i]);
            }
            Console.ReadKey();
        }
    }
}
