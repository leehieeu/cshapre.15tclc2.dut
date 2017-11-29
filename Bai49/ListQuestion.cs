using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai49
{
    class ListQuestion
    {
        protected List<Question> myList = new List<Question>();

        public void findByID()
        {
            Console.Write("Nhap vao ID can tim : ");
            int querryID = int.Parse(Console.ReadLine());
            foreach (Question q in myList)
            {
                if (querryID == q.pID_Question) q.showQuestion();
            }
        }

        public void findByTime()
        {
            Console.Write("Nhap vao thoi gian can tim : ");
            double querryTime = double.Parse(Console.ReadLine());
            foreach (Question q in myList)
            {
                if (querryTime == q.pMax_Time) q.showQuestion();
            }
        }

        public void findByContent()
        {
            Console.Write("Nhap vao noi dung can tim : ");
            string querryContent = Console.ReadLine();

            foreach (Question q in myList)
            {
                if (q.pContent_Question.Contains(querryContent))
                    q.showQuestion();
            }
        }

        public void findQuestion()
        {
            Console.WriteLine("\nTIM KIEM CAU HOI");
            Console.WriteLine("Tim sinh vien theo : ");
            Console.WriteLine("1.ID     2.Thoi gian     3.Noi Dung");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1) findByID();
            else if (choice == 2) findByTime();
            else if (choice == 3) findByContent();
            else
            {
                Console.WriteLine("Lua chon lai !");
                this.findQuestion();
            }
        }

        public void addQuestion()
        {
            Console.WriteLine("\nTHEM CAU HOI");
            Question q = new Question();
            myList.Add(q);
        }

        public int checkID()
        {
            findQuestion();
            Console.Write("Nhap vao ID cua cau hoi : ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public void delQuestion()
        {
            Console.WriteLine("\nXOA CAU HOI");
            int id = checkID();
            foreach (Question q in myList)
            {
                if (id == q.pID_Question)
                {
                    myList.Remove(q);
                    Console.WriteLine("Xoa thanh cong !");
                    return;
                }
            }
        }

        public void editQuestion()
        {
            Console.WriteLine("\nCHINH SUA THONG TIN ");
            int id = checkID();
            foreach (Question q in myList)
            {
                if (id == q.pID_Question)
                {
                    Console.WriteLine("Nhap vao lua chon : ");
                    Console.WriteLine("1.ID cau hoi             2.Noi dung cau hoi");
                    Console.WriteLine("3.Cau tra loi 1          4.Cau tra loi 2");
                    Console.WriteLine("5.Cau tra loi 3          6.Cau tra loi dung");
                    Console.WriteLine("7.Thoi gian toi da");
                    Console.Write("Lua chon : ");
                    int myChoice = int.Parse(Console.ReadLine());
                    switch (myChoice)
                    {
                        case 1:
                            {
                                Console.Write("Nhap vao ID cau hoi moi : ");
                                int newID = int.Parse(Console.ReadLine());
                                q.pID_Question = newID;
                                break;
                            }
                        case 2:
                            {
                                Console.Write("Nhap vao noi dung cau hoi moi : ");
                                string newContent = Console.ReadLine();
                                q.pContent_Question = newContent;
                                break;
                            }
                        case 3:
                            {
                                Console.Write("Nhap vao noi dung cau tra loi 1 moi : ");
                                string newAns = Console.ReadLine();
                                q.pAnswer1 = newAns;
                                break;
                            }
                        case 4:
                            {
                                Console.Write("Nhap vao noi dung cau tra loi 2 moi : ");
                                string newAns = Console.ReadLine();
                                q.pAnswer2 = newAns;
                                break;
                            }
                        case 5:
                            {
                                Console.Write("Nhap vao noi dung cau tra loi 3 moi : ");
                                string newAns = Console.ReadLine();
                                q.pAnswer3 = newAns;
                                break;
                            }
                        case 6:
                            {
                                Console.Write("Nhap vao noi dung cau tra loi dung moi : ");
                                string newAns = Console.ReadLine();
                                q.pRight_Answer = newAns;
                                break;
                            }
                        case 7:
                            {
                                Console.Write("Nhap vao thoi gian toi da moi :");
                                double newTime = double.Parse(Console.ReadLine());
                                q.pMax_Time = newTime;
                                break;
                            }
                    }
                }
                Console.WriteLine("CHINH SUA THANH CONG !");
            }
        }

        public void updateQuestion()
        {
            Console.WriteLine("\nLAM MOI DANH SACH");
            Console.WriteLine("\nLAM MOI DANH SACH");
            //list.Sort();
            foreach (Question q in myList)
            {
                q.showQuestion();
            }
        }
    }
}
