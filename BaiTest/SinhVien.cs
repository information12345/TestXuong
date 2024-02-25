using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTest
{
    internal class SinhVien
    {
        int ten;
        public int namSinh;
        double diem;
        public SinhVien()
        {
                
        }

        public SinhVien(int ten, int namSinh, double diem)
        {
            this.ten = ten;
            this.namSinh = namSinh;
            this.diem = diem;
        }

        public int Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double Diem { get => diem; set => diem = value; }
        public void InThongTin()
        {
            Console.WriteLine($"Tên Sinh Viên : {ten}, Năm Sinh : {namSinh}, Điểm {diem} ");
        }
    }
}
