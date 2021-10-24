using QuanLyCuaHangHonda.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.GUI
{
    class QuanLyKhachHang
    {
        public void Menu()
        {
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                        QUẢN LÝ KHÁCH HÀNG                     ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║                        1. THÊM KHÁCH HÀNG                     ║");
            Console.WriteLine("                            ║                        2. HIỂN THỊ DANH SÁCH NV               ║");
            Console.WriteLine("                            ║                        3. TÌM KIẾM                            ║");
            Console.WriteLine("                            ║                        4. CẬP NHẬT THÔNG TIN                  ║");
            Console.WriteLine("                            ║                        5. XÓA KHÁCH HÀNG                      ║");
            Console.WriteLine("                            ║                        0. THOÁT                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
        }
        public void Run()
        {
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            while (true)
            {
                Menu();
                Console.Write("Chọn: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        khachHangBLL.ThemKhachHang();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        khachHangBLL.HienDSKhachHang();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        khachHangBLL.timKhachHang();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        khachHangBLL.CapNhatKhachHang();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        khachHangBLL.XoaThongTin();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default: break;
                }
                if (chon == 0) break;
            }
        }
    }
}
