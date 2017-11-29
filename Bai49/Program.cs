using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai49
{
    class Program
    {

        static ListQuestion myList = new ListQuestion();
        static int choice = 0;

        static void showChoices()
        {
            Console.WriteLine("\nNhap vao lua chon : ");
            Console.WriteLine("1.Tim cau hoi            2.Tao moi cau hoi");
            Console.WriteLine("3.Xoa cau hoi            4.Chinh sua cau hoi");
            Console.WriteLine("5.Thoat                  6.Lam moi danh sach");
            Console.Write("Lua chon : ");
        }

        public static void consoleExecute()
        {
            choice = int.Parse(Console.ReadLine());

            while (choice > 6 || choice < 1)
            {
                Console.WriteLine("Nhap lai ");
                showChoices();
                choice = int.Parse(Console.ReadLine());
            }

            while (choice >= 1 && choice <= 6)
            {
                switch (choice)
                {
                    case 1:
                        {
                            myList.findQuestion();
                            break;
                        }
                    case 2:
                        {
                            myList.addQuestion();
                            break;
                        }
                    case 3:
                        {
                            myList.delQuestion();
                            break;
                        }
                    case 4:
                        {
                            myList.editQuestion();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\nTHOAT CHUONG TRINH");
                            return;
                        }
                    case 6:
                        {
                            myList.updateQuestion();
                            break;
                        }
                }
                showChoices();
                consoleExecute();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH QUAN LY CAU HOI CONSOLE");
            showChoices();
            consoleExecute();
            Console.ReadKey();
        }
    }
}
