using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào hệ số a : ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào hệ số b : ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào hệ số c : ");
            float c = float.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0 && c != 0) Console.WriteLine("Phương trình vô nghiệm ");
                else if (b == 0 && c == 0) Console.WriteLine("Phương trình vô số nghiệm");
                else Console.WriteLine("Nghiệm phương trình là : " + String.Format("{0:0.00}", (-c / b)));
            }
            else
            {

                float delta = (float)Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0) Console.WriteLine("Phương trình vô nghiệm ");
                else if (delta == 0) Console.WriteLine("Phương trình có nghiệm : " + String.Format("{0:0.00}", (-b / (2 * a))));
                else if (delta > 0)
                {
                    Console.WriteLine("Phương trình có 2 nghiệm : ");
                    Console.WriteLine("   x1 = " + String.Format("{0:0.00}", (-b - Math.Sqrt(delta)) / (2 * a)));
                    Console.WriteLine("   x2 = " + String.Format("{0:0.00}", (-b + Math.Sqrt(delta)) / (2 * a)));
                }
            }
            Console.ReadKey();

        }
    }
}
