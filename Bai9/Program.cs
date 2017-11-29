using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 1 số nguyên : ");
            int input = int.Parse(Console.ReadLine());
            String s = input.ToString();
            int max = s[0];
            for (int i=1;i<s.Length;i++)
            {
                if (s[i]== 9 )
                {
                    Console.WriteLine("Chữ số lớn nhất : 9 ");
                    return;
                }
                else if (max < s[i]) max = s[i];
            }
            Console.WriteLine("Chữ số lớn nhất : " + (max-48));
            Console.ReadKey();

        }
    }
}
