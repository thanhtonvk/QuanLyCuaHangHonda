using QuanLyCuaHangHonda.DAL;
using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.BLL
{
    class ChiTietHDBBLL
    {
        ChiTietHDBDAL chiTietHDBDAL;
        List<ChiTietHDB> chiTietHDBList;
        Random random;
        public ChiTietHDBBLL()
        {
            chiTietHDBDAL = new ChiTietHDBDAL();
            chiTietHDBList = chiTietHDBDAL.LayDSChiTietHDB();
            random = new Random();
        }
        public ChiTietHDB NhapChiTietHDB(string mahd)
        {
            ChiTietHDB chiTietHDB = new ChiTietHDB();
            chiTietHDB.Macthd = "CTHDB" + random.Next();
            chiTietHDB.Mahd = mahd;
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            SanPhamDAL sanPhamDAL = new SanPhamDAL();
            sanPhamBLL.HienDSSanPham();
            Console.Write("Chọn sản phẩm: ");
            int chonSP = int.Parse(Console.ReadLine());
            while (true)
            {
                if (chonSP > -1 && chonSP < sanPhamDAL.LayDSSanPham().Count) break;
                Console.Write("Sản phẩm không tồn tại");
                 chonSP = int.Parse(Console.ReadLine());
            }
            SanPham sanPham = sanPhamDAL.LayDSSanPham()[chonSP];
            chiTietHDB.Masp = sanPham.Masp;
            Console.Write("Nhập số lượng: ");
            chiTietHDB.Soluong = int.Parse(Console.ReadLine());
            while (true)
            {
                if (sanPham.Soluong > chiTietHDB.Soluong) break;
                Console.Write("Số lượng sản phẩm không đủ: ");
                chiTietHDB.Soluong = int.Parse(Console.ReadLine());
            }
            sanPhamBLL.UpdateSoLuong(-chiTietHDB.Soluong, chiTietHDB.Masp);
            return chiTietHDB;
        }
        public void ThemChiTietHDB(string mahd)
        {
            while (true)
            {
                ChiTietHDB chiTietHDB = NhapChiTietHDB(mahd);
                chiTietHDBList.Add(chiTietHDB);
                chiTietHDBDAL.GhiFile(chiTietHDBList);
                Console.Write("Bạn muốn mua nữa không? C/K  ");
                string chon = Console.ReadLine();
                if (chon.Equals("K") || chon.Equals('k')) break;
            }
        }
        public List<ChiTietHDB>GetChiTietHDB(string mahdb)
        {
            List<ChiTietHDB>chiTietHDBs = new List<ChiTietHDB>();
            foreach(ChiTietHDB chiTietHDB in chiTietHDBList)
            {
                if (chiTietHDB.Mahd.Equals(mahdb))
                {
                    chiTietHDBs.Add(chiTietHDB);
                }
            }
            return chiTietHDBs;
        }
        public int ThanhTien(string masp,int soluong)
        {
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            SanPham sanPham = sanPhamBLL.sanPham(masp);
            return sanPham.Giaban * soluong-sanPham.Khuyenmai;
        }
        private void HienChiTietHDB(ChiTietHDB chiTietHDB)
        {
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            SanPham sanPham = sanPhamBLL.sanPham(chiTietHDB.Masp);
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", sanPham.Masp, sanPham.Tensp, sanPham.Giaban, chiTietHDB.Soluong, ThanhTien(chiTietHDB.Masp,chiTietHDB.Soluong),sanPham.Khuyenmai);
        }
        public void HienDSCTHDB(string mahd)
        {
            int tong = 0;
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã sản phẩm", "Tên sản phẩm", "Giá bán", "Số lượng", "Thành tiền", "Khuyến mại");
            foreach(ChiTietHDB chiTietHDB in GetChiTietHDB(mahd))
            {
                HienChiTietHDB(chiTietHDB);
                tong += ThanhTien(chiTietHDB.Masp, chiTietHDB.Soluong);
            }
            Console.WriteLine("Tổng tiền thanh toán là: " + tong);
        }
    }
}
