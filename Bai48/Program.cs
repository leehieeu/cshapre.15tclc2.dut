using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai48
{
    class Program
    {
        static ListStudent myList = new ListStudent();
        static int choice = 0;

        static void showChoices()
        {
            Console.WriteLine("\nNhap vao lua chon : ");
            Console.WriteLine("1.Tim sinh vien     2.Tao moi sinh vien");
            Console.WriteLine("3.Xoa sinh vien     4.Chinh sua thong tin");
            Console.WriteLine("5.Thoat             6.Lam moi danh sach");
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
                            myList.findStudent();
                            break;
                        }
                    case 2:
                        {
                            myList.addStudent();
                            break;
                        }
                    case 3:
                        {
                            myList.deleteStudent();
                            break;
                        }
                    case 4:
                        {
                            myList.editStudent();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\nTHOAT CHUONG TRINH");
                            return;
                        }
                    case 6:
                        {
                            myList.updateList();
                            break;
                        }
                }
                showChoices();
                consoleExecute();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH QUAN LY SINH VIEN CONSOLE");
            showChoices();
            consoleExecute();
            Console.ReadKey();
        }
    }
}
