using QuanLyCuaHangHonda.DAL;
using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;

namespace QuanLyCuaHangHonda.BLL
{
    class SanPhamBLL
    {
        public List<SanPham> sanPhamList = new List<SanPham>();
        SanPhamDAL sanPhamDAL;
        public SanPhamBLL()
        {
            sanPhamDAL = new SanPhamDAL();
            sanPhamList = sanPhamDAL.LayDSSanPham();
        }
        public void ThemSanPham()
        {
            Console.Clear();
            ChiTietHDNBLL chiTietHDNBLL = new ChiTietHDNBLL();
            chiTietHDNBLL.HienDSCTHDN();
            SanPham sanPham = new SanPham();
            Console.WriteLine("Chọn mã sản phẩm: ");
            int chonMaSP = int.Parse(Console.ReadLine());
            if (chonMaSP > -1 && chonMaSP < chiTietHDNBLL.chiTietHDNList.Count)
            {
                ChiTietHDN chiTietHDN = chiTietHDNBLL.chiTietHDNList[chonMaSP];
                sanPham.Masp = chiTietHDN.Masp;
                sanPham.Giaban = (int)(chiTietHDN.Dongia * 1.1);
                sanPham.Soluong = chiTietHDN.Soluong;
            }
            Console.WriteLine("Nhập tên sản phẩm: ");
            sanPham.Tensp = Console.ReadLine();
            Console.WriteLine("Nhập thông số: ");
            sanPham.Thongso = Console.ReadLine();
            Console.WriteLine("Nhập màu sắc: ");
            sanPham.Mausac = Console.ReadLine();
            Console.WriteLine("Nhập khuyến mãi: ");
            sanPham.Khuyenmai = int.Parse(Console.ReadLine());
            sanPhamList.Add(sanPham);
            sanPhamDAL.GhiFile(sanPhamList);
        }
        public void UpdateSanPham()
        {
            Console.Clear();
            HienDSSanPham();
            Console.WriteLine("Chọn sản phẩm cần sửa: ");
            int chonSP = int.Parse(Console.ReadLine());
            if (chonSP > -1 && chonSP < sanPhamList.Count)
            {
                SanPham sanPham = sanPhamList[chonSP];
                Console.WriteLine("Nhập tên sản phẩm: ");
                sanPham.Tensp = Console.ReadLine();
                Console.WriteLine("Nhập thông số: ");
                sanPham.Thongso = Console.ReadLine();
                Console.WriteLine("Nhập màu sắc: ");
                sanPham.Mausac = Console.ReadLine();
                Console.WriteLine("Nhập khuyến mãi: ");
                sanPham.Khuyenmai = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập giá bán: ");
                sanPham.Giaban = int.Parse(Console.ReadLine());
                sanPhamList[chonSP] = sanPham;
                Console.WriteLine("Thành công");
                sanPhamDAL.GhiFile(sanPhamList);
            }
        }
        public void XoaSanPham()
        {
            Console.Clear();
            HienDSSanPham();
            Console.WriteLine("Chọn sản phẩm cần xóa: ");
            int chonSP = int.Parse(Console.ReadLine());
            if (chonSP > -1 && chonSP < sanPhamList.Count)
            {
                sanPhamList.RemoveAt(chonSP);
                sanPhamDAL.GhiFile(sanPhamList);
                Console.WriteLine("Thành công");
            }


        }
        public void HienSanPham(SanPham sanPham, int index)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", index, sanPham.Masp, sanPham.Tensp, sanPham.Thongso, sanPham.Mausac, sanPham.Khuyenmai, sanPham.Giaban, sanPham.Soluong);
        }
        public void HienDSSanPham()
        {
            Console.Clear();
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", "STT", "Mã sản phẩm", "Tên sản phẩm", "Thông số", "Màu sắc", "Khuyến mãi", "Giá bán", "Số lượng");
            int index = 0;
            foreach (SanPham sanPham in sanPhamList)
            {
                HienSanPham(sanPham, index);
                index++;
            }
        }
        public void TimKiem()
        {
            Console.Clear();
            Console.Write("Nhập từ khóa: ");
            string tukhoa = Console.ReadLine();
            int index = 0;
            foreach (SanPham sanPham in sanPhamList)
            {
                if (sanPham.Masp.Contains(tukhoa) ||
                    sanPham.Tensp.Contains(tukhoa) ||
                    sanPham.Mausac.Contains(tukhoa))
                {
                    HienSanPham(sanPham, index);
                    index++;
                }
            }
        }
        public void UpdateSoLuong(int soluong, string masp)
        {
            SanPham sp = new SanPham();
            int index = 0;
            bool check = false;
            foreach (SanPham sanPham in sanPhamList)
            {
                if (sanPham.Masp.Equals(masp))
                {
                    check = true;
                    break;
                }
                index++;
            }
            if (check)
            {
                sp = sanPhamList[index];
                sp.Soluong += soluong;
                sanPhamList[index] = sp;
                sanPhamDAL.GhiFile(sanPhamList);
            }

        }
        public SanPham sanPham(string masp)
        {
            SanPham kq = new SanPham();
            foreach (SanPham sp in sanPhamDAL.LayDSSanPham())
            {
                if (sp.Masp.Equals(masp)) kq = sp;
            }
            return kq;
        }
    }
}
