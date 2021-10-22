using QuanLyCuaHangHonda.Entities;
using System;

namespace QuanLyCuaHangHonda
{
    class Program
    {
        static void Main(string[] args)
        {
            KhachHang kh = new KhachHang();
            kh.Hoten = "Hương Lan";
            Console.WriteLine(kh);
        }
    }
}
