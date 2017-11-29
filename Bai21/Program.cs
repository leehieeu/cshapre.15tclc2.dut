using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21
{
    class Program
    {
        public static string daoChuoi(string input)
        {
            string temp = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                temp = temp + input[i];
            }
            return temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 1 chuỗi : ");
            string input = Console.ReadLine();
            string res = daoChuoi(input);
            Console.WriteLine("Chuỗi đã đảo ngược là : " + res);
            Console.ReadKey();
        }
    }
}
