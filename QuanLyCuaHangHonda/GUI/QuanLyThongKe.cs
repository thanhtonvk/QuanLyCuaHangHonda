using QuanLyCuaHangHonda.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.GUI
{
     class QuanLyThongKe
    {
        public void Menu()
        {
            Console.WriteLine("                            ╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                            ║                        THỐNG KÊ                               ║");
            Console.WriteLine("                            ║═══════════════════════════════════════════════════════════════║");
            Console.WriteLine("                            ║                        1. DANH SÁCH XE CÒN TRONG KHO          ║");
            Console.WriteLine("                            ║                        2. THỐNG KÊ THU NHẬP THEO THÁNG        ║");
            Console.WriteLine("                            ║                        0. THOÁT                               ║");
            Console.WriteLine("                            ╚═══════════════════════════════════════════════════════════════╝");
        }
        public void Run()
        {
          ThongKe thongKe = new ThongKe();
            while (true)
            {
                Menu();
                Console.Write("Chọn: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        thongKe.ThongKeSoLuongCon();
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        thongKe.TongThuTheoThang();
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
