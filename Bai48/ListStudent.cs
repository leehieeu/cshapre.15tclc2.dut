using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai48
{
    class ListStudent
    {
        //protected Student student;
        //protected Student[]list ;
        protected List<Student> list = new List<Student>();

        public void findByName()
        {
            Console.Write("Nhap vao ten sinh vien can tim : ");
            string querryName = Console.ReadLine();

            foreach (Student st in list)
            {
                if (st.pTenSV.Contains(querryName) == true)
                {
                    Console.WriteLine();
                    st.showInformation();
                }
            }
        }

        public void findByID()
        {
            Console.Write("Nhap vao ma so sinh vien : ");
            int querryID = int.Parse(Console.ReadLine());

            foreach (Student st in list)
            {
                if (querryID == st.pMaSoSV)
                {
                    Console.WriteLine();
                    st.showInformation();
                }
            }
        }

        public void findByGroup()
        {
            Console.Write("Nhap vao ten khoa : ");
            string querryGroup = Console.ReadLine();

            foreach (Student st in list)
            {
                if (st.pKhoa.Contains(querryGroup) == true)
                {
                    Console.WriteLine();
                    st.showInformation();
                }
            }
        }

        public void findByMark()
        {
            Console.Write("Nhap vao diem cua sinh vien : ");
            double querryMark = double.Parse(Console.ReadLine());

            foreach (Student st in list)
            {
                if (querryMark == st.pDiemTB)
                {
                    Console.WriteLine();
                    st.showInformation();
                }
            }
        }

        public void findStudent()
        {
            Console.WriteLine("\nTIM KIEM SINH VIEN");
            Console.WriteLine("Tim sinh vien theo : ");
            Console.WriteLine("1.Ten SV     2.Ma So     3.Khoa     4.Diem trung binh");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1) findByName();
            else if (choice == 2) findByID();
            else if (choice == 3) findByGroup();
            else if (choice == 4) findByMark();
            else
            {
                Console.WriteLine("Lua chon lai !");
                this.findStudent();
            }
        }

        public void addStudent()
        {
            Console.WriteLine("\nTHEM SINH VIEN");
            Student st = new Student();

            this.list.Add(st);
        }

        public int checkID()
        {
            findStudent();
            Console.Write("Nhap vao ID cua sinh vien : ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public void deleteStudent()
        {
            Console.WriteLine("\nXOA SINH VIEN");
            int id = checkID();
            foreach (Student st in list)
            {
                if (id == st.pMaSoSV)
                {
                    list.Remove(st);
                    Console.WriteLine("Xoa thanh cong !");
                    return;
                }
            }
        }

        public void editStudent()
        {
            Console.WriteLine("\nCHINH SUA THONG TIN ");
            int id = checkID();
            foreach (Student st in list)
            {
                if (id == st.pMaSoSV)
                {
                    Console.WriteLine("Nhap vao lua chon : ");
                    Console.WriteLine("1.Ma so sinh vien     2.Ten sinh vien");
                    Console.WriteLine("3.Khoa                4.Diem trung binh");
                    Console.WriteLine("5.Diem ren luyen");
                    Console.Write("Lua chon : ");
                    int myChoice = int.Parse(Console.ReadLine());
                    switch (myChoice)
                    {
                        case 1:
                            {
                                Console.Write("Nhap vao MSSV moi : ");
                                int newID = int.Parse(Console.ReadLine());
                                st.pMaSoSV = newID;
                                break;
                            }
                        case 2:
                            {
                                Console.Write("Nhap vao ten moi : ");
                                string newName = Console.ReadLine();
                                st.pTenSV = newName;
                                break;
                            }
                        case 3:
                            {
                                Console.Write("Nhap vao khoa moi : ");
                                string newGroup = Console.ReadLine();
                                st.pKhoa = newGroup;
                                break;
                            }
                        case 4:
                            {
                                Console.Write("Nhap vao diem trung binh moi : ");
                                double newGrade = double.Parse(Console.ReadLine());
                                st.pDiemTB = newGrade;
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Nhap vao diem ren luyen moi : ");
                                int newGrade = int.Parse(Console.ReadLine());
                                st.pDiemRL = newGrade;
                                break;
                            }
                    }
                    Console.WriteLine("CHINH SUA THANH CONG !");
                }
            }
        }

        public void updateList()
        {
            Console.WriteLine("\nLAM MOI DANH SACH");
            //list.Sort();
            foreach (Student st in list)
            {
                st.showInformation();
            }
        }

    }
}
