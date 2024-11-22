using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VienKhoaHoc vienKhoaHoc = new VienKhoaHoc();
            while (true)
            {
                Console.WriteLine("1. Nhap thong tin nhan vien");
                Console.WriteLine("2. Xuat thong tin nhan vien");
                Console.WriteLine("3. Tinh luong nhan vien");
                Console.WriteLine("4. Thoat");
                Console.Write("Nhap lua chon cua ban: ");
                int luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        vienKhoaHoc.Nhap();
                        break;
                    case 2:
                        vienKhoaHoc.Xuat();
                        break;
                    case 3:
                        vienKhoaHoc.TongLuongTheoLoaiNhanVien();
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
