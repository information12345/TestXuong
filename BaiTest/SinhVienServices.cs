using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTest
{
    internal class SinhVienServices : SinhVien
    {
        List<SinhVien> List = new List<SinhVien>();
        public void NhapDs()
        {
            Console.WriteLine("Bạn muốn nhập bao nhiêu ");
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                SinhVien sv = new SinhVien();
                Console.WriteLine("Nhập Tên Sinh Viên ");
                sv.Ten = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập Năm Sinh Của Nhân Viên ");
                sv.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập Điểm Của Sinh Viên ");
                sv.Diem = Convert.ToInt32(Console.ReadLine());
                List.Add(sv);
            }
            Console.WriteLine("Bạn có muốn nhập tiếp không Y nếu có , còn lại là không ");
            string choose = Console.ReadLine();
            if(choose == "Y")
            {
                NhapDs();
            }

        }
        public void XuatDs()
        {
            if(List.Count == 0 )
            {
                Console.WriteLine("Bạn Chưa Nhập Gì, Nhập Danh Sách Đã ");
                NhapDs();
            }
            foreach (var item in List)
            {
                item.InThongTin();
            }
        }
        public void XuatDsHappybee()
        {
            foreach (var item in List)
            {
                if(item.Diem >=8)
                {
                    item.InThongTin();
                }
            }
        }
        public void Xoa()
        {
            Console.WriteLine("Xóa Sinh Viên K được Vé Happybee");
            int tuoi = 2024 - namSinh;
            foreach (var item in List.ToList())
            {
                if (tuoi >24 ) List.Remove(item);
            }
        }
    }
}
