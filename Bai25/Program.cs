using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào 1 chuỗi : ");
            string input = Console.ReadLine();
            char[] a = input.ToCharArray();
            int index = 0;
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] >= 37 && a[i] <= 47)
                {
                    index = i;
                    break;
                }
            }
            if (index == 0)
            {
                Console.WriteLine("Không có phép tính nào ");
                Console.ReadKey();
                return;
            }
            string s1, s2;
            s1 = input.Substring(0, index);
            s2 = input.Substring(index + 1, input.Length - index - 1);
            int num1 = int.Parse(s1);
            int num2 = int.Parse(s2);
            int checkOperator = (int)a[index];
            Console.Write("Kết quả là : ");
            switch (checkOperator)
            {
                case 37:
                    {
                        Console.WriteLine(num1 % num2);
                        break;
                    }
                case 42:
                    {
                        Console.WriteLine(num1 * num2);
                        break;
                    }
                case 43:
                    {
                        Console.WriteLine(num1 + num2);
                        break;
                    }
                case 45:
                    {
                        Console.WriteLine(num1 - num2);
                        break;
                    }
                case 47:
                    {
                        Console.WriteLine(num1 / num2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Không thể tính toán ");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
