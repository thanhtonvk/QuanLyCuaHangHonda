using QuanLyCuaHangHonda.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.GUI
{
    class QuanLyHoaDonNhap
    {
        public void Menu()
        {
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                        QUẢN LÝ NHẬP HÀNG                      ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║                        1. THÊM HÓA ĐƠN                        ║");
            Console.WriteLine("                            ║                        2. HIỂN THỊ DANH SÁCH HÓA ĐƠN          ║");
            Console.WriteLine("                            ║                        3. TÌM KIẾM                            ║");
            Console.WriteLine("                            ║                        0. THOÁT                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
        }
        public void Run()
        {
            HoaDonNhapBLL hoaDonNhapBLL = new HoaDonNhapBLL();
            while (true)
            {
                Menu();
                Console.Write("Chọn: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        hoaDonNhapBLL.ThemHoaDon();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        hoaDonNhapBLL.HienDSHoaDon();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        hoaDonNhapBLL.TimKiemHoaDonNhap();
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
