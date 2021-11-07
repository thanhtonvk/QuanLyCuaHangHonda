using QuanLyCuaHangHonda.BLL;
using QuanLyCuaHangHonda.Entities;
using QuanLyCuaHangHonda.GUI;
using System;

namespace QuanLyCuaHangHonda
{
    class Program
    {
       static void Menu()
        {
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                        QUẢN LÝ CỬA HÀNG XE MÁY HONDA          ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║                        1. QUẢN LÝ XE MÁY                      ║");
            Console.WriteLine("                            ║                        2. QUẢN LÝ KHÁCH HÀNG                  ║");
            Console.WriteLine("                            ║                        3. QUẢN LÝ NHÂN VIÊN                   ║");
            Console.WriteLine("                            ║                        4. NHẬP XE                             ║");
            Console.WriteLine("                            ║                        5. BÁN XE                              ║");
            Console.WriteLine("                            ║                        6. THỐNG KÊ                            ║");
            Console.WriteLine("                            ║                        0. THOÁT                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            while (true)
            {
                Menu();
                Console.Write("Chọn chức năng: ");
                int chon = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (chon)
                {
                    case 1:
                        new QuanLySanPham().Run();
                        break;
                    case 2:
                        new QuanLyKhachHang().Run();
                        break;
                    case 3:
                        new QuanLyNhanVien().Run();
                        break;
                    case 4:
                        new QuanLyHoaDonNhap().Run();
                        break;
                    case 5:
                        new QuanLyHoaDonXuat().Run();
                        break;
                    case 6:
                        new QuanLyThongKe().Run();
                        break;
                    default:break;
                }
                if (chon == 0) break;
            }

        }
    }
}
