using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai48
{

    class Student
    {
        private int MaSoSV;
        private string TenSV;
        private string Khoa;
        private double DiemTB;
        private int DiemRL;
        private string XepLoai;

        public int pMaSoSV
        {
            get
            {
                return MaSoSV;
            }

            set
            {
                MaSoSV = value;
            }
        }

        public string pTenSV
        {
            get
            {
                return TenSV;
            }

            set
            {
                TenSV = value;
            }
        }

        public string pKhoa
        {
            get
            {
                return Khoa;
            }

            set
            {
                Khoa = value;
            }
        }

        public double pDiemTB
        {
            get
            {
                return DiemTB;
            }

            set
            {
                if (value >= 0 && value <= 10)
                    DiemTB = value;
                else DiemRL = 0;
            }
        }

        public int pDiemRL
        {
            get
            {
                return DiemRL;
            }

            set
            {
                if (value >= 0 && value <= 100)
                    DiemRL = value;
                else DiemRL = 0;
            }
        }

        public string pXepLoai
        {
            get
            {
                return XepLoai;
            }

            set
            {
                XepLoai = this.rankStudent();
            }
        }

        public Student(int maSoSV, string tenSV, string khoa, double diemTB, int diemRL, string xepLoai)
        {

            this.pMaSoSV = maSoSV;
            this.pTenSV = tenSV;
            this.pKhoa = khoa;
            this.pDiemTB = diemTB;
            this.pDiemRL = diemRL;
            this.pXepLoai = xepLoai;
        }

        public Student(int maSoSV, string tenSV, string khoa, double diemTB, int diemRL)
        {
            pMaSoSV = maSoSV;
            pTenSV = tenSV;
            pKhoa = khoa;
            pDiemTB = diemTB;
            pDiemRL = diemRL;
            this.pXepLoai = this.rankStudent();
        }

        public Student()
        {
            Console.Write("Nhap vao ma so sinh vien : ");
            this.pMaSoSV = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao ten sinh vien : ");
            this.pTenSV = Console.ReadLine();
            Console.Write("Nhap vao khoa : ");
            this.pKhoa = Console.ReadLine();
            Console.Write("Nhap vao diem trung binh : ");
            this.pDiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao diem ren luyen : ");
            this.pDiemRL = int.Parse(Console.ReadLine());
        }

        public string rankStudent()
        {
            if (this.pDiemTB >= 9)
            {
                if (this.pDiemRL >= 90) return "Xuat sac";
                else if (this.pDiemRL >= 80) return "Gioi";
                else if (this.pDiemRL >= 70) return "Kha";
            }

            else if (this.pDiemTB >= 8)
            {
                if (this.pDiemRL >= 80) return "Gioi";
                else return "Kha";
            }

            else if (this.pDiemTB >= 7 && this.pDiemRL >= 70) return "Kha";

            return "Yeu";
        }

        public void showInformation()
        {
            this.pXepLoai = this.rankStudent();
            Console.WriteLine("HIEN THI THONG TIN SINH VIEN");
            Console.WriteLine("Ma so sinh vien : " + this.pMaSoSV);
            Console.WriteLine("Ten sinh vien : " + this.pTenSV);
            Console.WriteLine("Khoa : " + this.pKhoa);
            Console.WriteLine("Diem trung binh : " + this.pDiemTB);
            Console.WriteLine("Diem ren luyen : " + this.pDiemRL);
            Console.WriteLine("Xep loai : " + this.pXepLoai);
            Console.WriteLine();
        }

    }
}
