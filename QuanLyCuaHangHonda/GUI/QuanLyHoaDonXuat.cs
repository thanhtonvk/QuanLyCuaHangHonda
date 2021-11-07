using QuanLyCuaHangHonda.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.GUI
{
    class QuanLyHoaDonXuat
    {
        public void Menu()
        {
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                        QUẢN LÝ BÁN HÀNG                       ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║                        1. THÊM HÓA ĐƠN                        ║");
            Console.WriteLine("                            ║                        2. HIỂN THỊ DANH SÁCH HÓA ĐƠN          ║");
            Console.WriteLine("                            ║                        0. THOÁT                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
        }
        public void Run()
        {
            HoaDonBanBLL hoaDonBanBLL = new HoaDonBanBLL();
            while (true)
            {
                Menu();
                Console.Write("Chọn: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        hoaDonBanBLL.ThemHoaDonBan();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        hoaDonBanBLL.HienDSHoaDonBan();
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
