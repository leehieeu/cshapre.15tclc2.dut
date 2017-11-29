using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai49
{
    class Question
    {
        private int ID_Question;
        private string Content_Question;
        private string Answer1;
        private string Answer2;
        private string Answer3;
        private string Right_Answer;
        private double Max_Time;

        public string pContent_Question
        {
            get
            {
                return Content_Question;
            }

            set
            {
                Content_Question = value;
            }
        }

        public string pAnswer1
        {
            get
            {
                return Answer1;
            }

            set
            {
                Answer1 = value;
            }
        }

        public string pAnswer2
        {
            get
            {
                return Answer2;
            }

            set
            {
                Answer2 = value;
            }
        }

        public string pAnswer3
        {
            get
            {
                return Answer3;
            }

            set
            {
                Answer3 = value;
            }
        }

        public string pRight_Answer
        {
            get
            {
                return Right_Answer;
            }

            set
            {
                Right_Answer = value;
            }
        }

        public double pMax_Time
        {
            get
            {
                return Max_Time;
            }

            set
            {
                Max_Time = value;
            }
        }

        public int pID_Question
        {
            get
            {
                return ID_Question;
            }

            set
            {
                ID_Question = value;
            }
        }

        public Question()
        {
            Console.WriteLine("Nhap vao ID cau hoi : ");
            this.pID_Question = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao noi dung cau hoi : ");
            this.pContent_Question = Console.ReadLine();
            Console.Write("Nhap vao cau tra loi 1 : ");
            this.pAnswer1 = Console.ReadLine();
            Console.Write("Nhap vao cau tra loi 2 : ");
            this.pAnswer2 = Console.ReadLine();
            Console.Write("Nhap vao cau tra loi 3 : ");
            this.pAnswer3 = Console.ReadLine();
            Console.Write("Nhap vao cau tra loi dung : ");
            this.pRight_Answer = Console.ReadLine();
            Console.Write("Nhap vao thoi gian toi da : ");
            this.pMax_Time = double.Parse(Console.ReadLine());
        }

        public void showQuestion()
        {
            Console.Write("Noi dung cau hoi la : ");
            Console.Write(this.pContent_Question);
        }
    }
}
