using QuanLyCuaHangHonda.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangHonda.Entities;
namespace QuanLyCuaHangHonda.BLL
{
    class ThongKe
    {
        public void ThongKeSoLuongCon()
        {
            SanPhamDAL sanPhamDAL = new SanPhamDAL();
            Console.WriteLine("Số lượng sản phẩm còn là: ");
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", "Mã xe", "Tên xe", "Số lượng còn");
            foreach(SanPham sanPham in sanPhamDAL.LayDSSanPham())
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", sanPham.Masp, sanPham.Tensp, sanPham.Soluong);
            }
        }
        public void TongThuTheoThang()
        {
            int tongthu = 0;
            Console.WriteLine("Nhập tháng/năm: ");
            string thang = Console.ReadLine();
            HoaDonBanBLL hoaDonBanBLL = new HoaDonBanBLL();
            HoaDonBanDAL hoaDonBanDAL = new HoaDonBanDAL();
            ChiTietHDBBLL chiTietHDBBLL = new ChiTietHDBBLL();
            foreach(HoaDonBan hoaDonBan in hoaDonBanDAL.LayDSHoaDonBan())
            {
                if (hoaDonBan.Ngayban.Contains(thang))
                {
                    List<ChiTietHDB> chiTietHDBs = chiTietHDBBLL.GetChiTietHDB(hoaDonBan.Mahd);
                    foreach(ChiTietHDB chiTietHDB in chiTietHDBs)
                    {
                        tongthu += chiTietHDBBLL.ThanhTien(chiTietHDB.Masp, chiTietHDB.Soluong);
                    }
                }
            }
            Console.WriteLine("Tổng thu nhập tháng " + thang + " là: " + tongthu);
        }
    }
}
