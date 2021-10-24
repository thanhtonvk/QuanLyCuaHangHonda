using QuanLyCuaHangHonda.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.GUI
{
    class QuanLyNhanVien
    {
        public void Menu()
        {
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                        QUẢN LÝ NHÂN VIÊN                      ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║                        1. THÊM NHÂN VIÊN                      ║");
            Console.WriteLine("                            ║                        2. HIỂN THỊ DANH SÁCH NV               ║");
            Console.WriteLine("                            ║                        3. TÌM KIẾM                            ║");
            Console.WriteLine("                            ║                        4. CẬP NHẬT THÔNG TIN                  ║");
            Console.WriteLine("                            ║                        5. XÓA NHÂN VIÊN                       ║");
            Console.WriteLine("                            ║                        0. THOÁT                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
        }
        public void Run()
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            while (true)
            {
                Menu();
                Console.Write("Chọn: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nhanVienBLL.ThemNhanVien();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        nhanVienBLL.HienDSNhanVien();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        nhanVienBLL.timNhanVien();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        nhanVienBLL.CapNhatNhanVien();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        nhanVienBLL.XoaThongTin();
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
