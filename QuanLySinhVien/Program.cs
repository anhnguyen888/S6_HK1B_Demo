using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();

            while (true)
            {
                Console.WriteLine("1. Nhap 1 sinh vien");
                Console.WriteLine("2. Xuat danh sach sinh vien");
                Console.WriteLine("3. Tim kiem sinh vien theo ten");
                Console.WriteLine("4. Tim kiem sinh vien co diem >=5");
                Console.WriteLine("0. Thoat");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SinhVien sv = new SinhVien();
                        sv.Nhap();
                        listSinhVien.Add(sv);
                        break;
                    case 2:
                        foreach (var sinhVien in listSinhVien)
                        {
                            sinhVien.Xuat();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Nhap ten sinh vien can tim: ");
                        string ten = Console.ReadLine();
                        foreach (var sinhVien in listSinhVien.Where(x => x.HoTen.Equals(ten)))
                        {
                            sinhVien.Xuat();
                        }
                        break;
                    case 4:
                        foreach (var sinhVien in listSinhVien.Where(x => x.Diem >=5 && x.Khoa.ToLower() == "cntt"))
                        {
                            sinhVien.Xuat();
                        }
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

        }
    }
}
