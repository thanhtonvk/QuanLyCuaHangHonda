using QuanLyCuaHangHonda.DAL;
using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.BLL
{
    class ChiTietHDNBLL
    {
        public List<ChiTietHDN> chiTietHDNList;
        ChiTietHDNDAL chiTietHDNDAL;
        Random random;
        public ChiTietHDNBLL()
        {
            chiTietHDNDAL = new ChiTietHDNDAL();
            chiTietHDNList = chiTietHDNDAL.LayDSChiTietHDN();
            random = new Random();
        }
        public ChiTietHDN NhapChiTietHDN(string MaHDN)
        {
            ChiTietHDN chiTietHDN = new ChiTietHDN();
            chiTietHDN.Macthdn = "CTHDN" + random.Next();
            chiTietHDN.Mahdn = MaHDN;
            Console.WriteLine("Nhập mã sản phẩm: ");
            chiTietHDN.Masp = Console.ReadLine();
            //cần tăng số lượng sản phẩm
            Console.WriteLine("Nhập số lượng: ");
            chiTietHDN.Soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("Đơn giá: ");
            chiTietHDN.Dongia = int.Parse(Console.ReadLine());

            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            sanPhamBLL.UpdateSoLuong(chiTietHDN.Soluong, chiTietHDN.Masp);
            return chiTietHDN;
        }

        public void HienChiTietHDN(ChiTietHDN chiTietHDN)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", chiTietHDN.Mahdn, chiTietHDN.Macthdn, chiTietHDN.Masp, chiTietHDN.Soluong, chiTietHDN.Dongia, chiTietHDN.Soluong * chiTietHDN.Dongia);
        }
        public void HienDSCTHDN(string MaHDN)
        {
            Console.Clear();
            long tong = 0;
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã hóa đơn", "Mã CT hóa đơn", "Mã sản phẩm", "Số lượng", "Đơn giá", "Thành tiền");
            foreach (ChiTietHDN chiTietHDN in chiTietHDNList)
            {
                if (chiTietHDN.Mahdn.Equals(MaHDN))
                {
                    HienChiTietHDN(chiTietHDN);
                    tong += chiTietHDN.Dongia * chiTietHDN.Soluong;
                }

            }
            Console.WriteLine("Tổng thanh toán là: " + tong);
        }
        public void HienChiTietHDN(ChiTietHDN chiTietHDN, int index)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", index, chiTietHDN.Masp, chiTietHDN.Soluong, chiTietHDN.Dongia);
        }
        public void HienDSCTHDN()
        {
            int index = 0;
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", "STT", "Mã sản phẩm", "Số lượng", "Đơn giá");
            foreach (ChiTietHDN chiTietHDN in chiTietHDNList)
            {
                HienChiTietHDN(chiTietHDN,index);
                index++;
            }
        }
        public void ThemChiTietHDN(string MaHDN)
        {
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            while (true)
            {
                Console.Clear();
                ChiTietHDN chiTietHDN = NhapChiTietHDN(MaHDN);
                chiTietHDNList.Add(chiTietHDN);
                sanPhamBLL.UpdateSoLuong(chiTietHDN.Soluong, chiTietHDN.Masp);
                chiTietHDNDAL.GhiFile(chiTietHDNList);
                Console.WriteLine("Bạn muốn nhập tiếp không? C/K");
                string chon = Console.ReadLine();
                if (chon == "k" || chon == "K") break;
            }
            Console.WriteLine("Thông tin hóa đơn: ");
            HienDSCTHDN(MaHDN);
        }

    }
}
