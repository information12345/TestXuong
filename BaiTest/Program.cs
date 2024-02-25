namespace BaiTest
{
    internal class Program
    {
        public static string Menu()
        {
            Console.WriteLine("1: Nhap");
            Console.WriteLine("2: Xuat");
            Console.WriteLine("3: Xuat Sv co ve happybee ");
            Console.WriteLine("4: Xoa  ");
            Console.WriteLine("0: Thoat");
            Console.WriteLine("Hãy nhap lua chon cua ban");
            string choose = Console.ReadLine();
            return choose;
        }
        static void Main(string[] args)
        {
            SinhVienServices sv1 = new SinhVienServices();
            while (true)
            {
                switch (Menu())
                {
                    case "1":
                        sv1.NhapDs(); break;
                    case "2":
                        sv1.XuatDs(); break;
                    case "3":
                        sv1.XuatDsHappybee(); break;
                    case "4":
                        sv1.Xoa(); break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nhập từ 0 đến 4 thôi ông nội =))");
                        break;

                }
            }
        }
    }
}
