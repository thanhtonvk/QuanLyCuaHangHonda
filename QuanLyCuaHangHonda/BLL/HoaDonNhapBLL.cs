using QuanLyCuaHangHonda.DAL;
using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.BLL
{
    class HoaDonNhapBLL
    {
        List<HoaDonNhap> hoaDonNhapList;
        HoaDonNhapDAL hoaDonNhapDAL;
        Random random;
        public HoaDonNhapBLL()
        {
            hoaDonNhapDAL = new HoaDonNhapDAL();
            hoaDonNhapList = hoaDonNhapDAL.LayDSHoaDonNhap();
            random = new Random();
        }
        public void ThemHoaDon()
        {
            Console.Clear();
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            HoaDonNhap hoaDonNhap = new HoaDonNhap();
            hoaDonNhap.Mahd = "HDN" + random.Next();
            nhanVienBLL.HienDSNhanVien();
            Console.Write("chọn nhân viên: ");
            int chonNV = int.Parse(Console.ReadLine());
            if (chonNV > -1 && chonNV < nhanVienBLL.nhanVienList.Count)
            {
                NhanVien nhanVien = nhanVienBLL.nhanVienList[chonNV];
                hoaDonNhap.Manv = nhanVien.Manv;
            }
            Console.WriteLine("Ngày nhập: ");
            hoaDonNhap.Ngay = Console.ReadLine();
            hoaDonNhapList.Add(hoaDonNhap);
            hoaDonNhapDAL.GhiFile(hoaDonNhapList);
            ChiTietHDNBLL chiTietHDNBLL = new ChiTietHDNBLL();
            chiTietHDNBLL.ThemChiTietHDN(hoaDonNhap.Mahd);
            Console.WriteLine("Mã hóa đơn: " + hoaDonNhap.Mahd);
            Console.WriteLine("Mã nhân viên: " + hoaDonNhap.Manv);
            Console.WriteLine("Ngày nhập: " + hoaDonNhap.Ngay);
        }
        public void HienHoaDon(HoaDonNhap hoaDonNhap,int index)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", index, hoaDonNhap.Mahd,hoaDonNhap.Ngay, hoaDonNhap.Manv);
        }
        public void HienDSHoaDon()
        {
            Console.Clear();
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", "STT", "Mã hóa đơn", "Ngày nhập", "Mã nhân viên");
            int index = 0;
            foreach(HoaDonNhap hoaDonNhap in hoaDonNhapList)
            {
                HienHoaDon(hoaDonNhap,index);
                index++;
            }
            Console.WriteLine("Chọn hóa đơn muốn xem chi tiết(nhập -1 để thoát)");
            int chon = int.Parse(Console.ReadLine());
            if (chon > -1 && chon < hoaDonNhapList.Count)
            {
                HoaDonNhap hoaDonNhap = hoaDonNhapList[chon];
                ChiTietHDNBLL chiTietHDNBLL = new ChiTietHDNBLL();
                chiTietHDNBLL.HienDSCTHDN(hoaDonNhap.Mahd);
            }
        }
        public void TimKiemHoaDonNhap()
        {
            Console.Clear();
            Console.WriteLine("Nhập từ khóa cần tìm: ");
            string tukhoa = Console.ReadLine();
            List<HoaDonNhap> timKiem = HoaDonNhapList(tukhoa);
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", "STT", "Mã hóa đơn", "Ngày nhập", "Mã nhân viên");
            int index = 0;
            foreach (HoaDonNhap hoaDonNhap in timKiem)
            {
                HienHoaDon(hoaDonNhap, index);
                index++;
            }
            Console.WriteLine("Chọn hóa đơn muốn xem chi tiết(nhập -1 để thoát)");
            int chon = int.Parse(Console.ReadLine());
            if (chon > -1 && chon < timKiem.Count)
            {
                HoaDonNhap hoaDonNhap = timKiem[chon];
                ChiTietHDNBLL chiTietHDNBLL = new ChiTietHDNBLL();
                chiTietHDNBLL.HienDSCTHDN(hoaDonNhap.Mahd);
            }
        }
        public List<HoaDonNhap>HoaDonNhapList(string tukhoa)
        {
            List<HoaDonNhap> kq = new List<HoaDonNhap> ();
            foreach(HoaDonNhap hoaDonNhap in hoaDonNhapList)
            {
                if(hoaDonNhap.Mahd.Contains(tukhoa)||
                    hoaDonNhap.Ngay.Contains(tukhoa)||
                    hoaDonNhap.Manv.Contains(tukhoa))
                {
                    kq.Add(hoaDonNhap);
                }
            }
            return kq;
        }
    }
}
