using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class SinhVien
    {
        public int MaSo { get; set; }
        public string HoTen { get; set; }
        public string Khoa { get; set; }
        public float Diem { get; set; }

        // Hàm nhập sinh viên
        public void Nhap()
        {
            Console.WriteLine("Nhap ma so sinh vien: ");
            MaSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ho ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap khoa: ");
            Khoa = Console.ReadLine();
            Console.WriteLine("Nhap diem: ");
            Diem = float.Parse(Console.ReadLine());
        }
        // Xuất sinh viên 
        public void Xuat()
        {
            Console.WriteLine("Ma so sinh vien: " + MaSo);
            Console.WriteLine("Ho ten sinh vien: " + HoTen);
            Console.WriteLine("Khoa: " + Khoa);
            Console.WriteLine("Diem: " + Diem);
        }
    }
}
