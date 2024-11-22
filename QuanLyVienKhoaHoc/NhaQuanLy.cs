using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc
{
    internal class NhaQuanLy : NhanVien
    {
        public string ChucVu { get; set; }
        public int SoNgayCong { get; set; }
        public float BacLuong { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("Nhap so ngay cong: ");
            SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap bac luong: ");
            BacLuong = float.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Chuc vu: " + ChucVu);
            Console.WriteLine("So ngay cong: " + SoNgayCong);
            Console.WriteLine("Bac luong: " + BacLuong);
        }

        public override double TinhLuong()
        {
            return SoNgayCong * BacLuong;
        }
    }
}
