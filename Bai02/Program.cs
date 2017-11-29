using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào điểm  :");
            Console.Write("Toan ");
            float toan = float.Parse(Console.ReadLine());
            Console.Write("Lý ");
            float ly = float.Parse(Console.ReadLine());
            Console.Write("Hóa ");
            float hoa = float.Parse(Console.ReadLine());
            Console.WriteLine("Điểm trung bình là : " + String.Format("{0:0.00}", (toan + ly + hoa) / 3));
            Console.ReadKey();
        }
    }
}
