using QuanLyCuaHangHonda.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.GUI
{
    class QuanLySanPham
    {
        public void Menu()
        {
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                        QUẢN LÝ XE MÁY                         ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║                        1. THÊM XE                             ║");
            Console.WriteLine("                            ║                        2. HIỂN THỊ DANH SÁCH XE               ║");
            Console.WriteLine("                            ║                        3. TÌM KIẾM                            ║");
            Console.WriteLine("                            ║                        4. CẬP NHẬT THÔNG TIN                  ║");
            Console.WriteLine("                            ║                        5. XÓA XE                              ║");
            Console.WriteLine("                            ║                        0. THOÁT                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
        }
        public void Run()
        {
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            while (true)
            {
                Menu();
                Console.Write("Chọn: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        sanPhamBLL.ThemSanPham();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        sanPhamBLL.HienDSSanPham();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        sanPhamBLL.TimKiem();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        sanPhamBLL.UpdateSanPham();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        sanPhamBLL.XoaSanPham();
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
