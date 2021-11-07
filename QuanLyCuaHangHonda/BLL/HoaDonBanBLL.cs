using QuanLyCuaHangHonda.DAL;
using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;

namespace QuanLyCuaHangHonda.BLL
{
    class HoaDonBanBLL
    {
        List<HoaDonBan> hoaDonBanList;
        HoaDonBanDAL hoaDonBanDAL;
        Random random;
        public HoaDonBanBLL()
        {
            hoaDonBanDAL = new HoaDonBanDAL();
            hoaDonBanList = hoaDonBanDAL.LayDSHoaDonBan();
            random= new Random();
        }
        public HoaDonBan NhapHDB()
        {
            HoaDonBan HDB = new HoaDonBan();
            HDB.Mahd = "HDB"+random.Next();
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            nhanVienBLL.HienDSNhanVien();
            Console.Write("Chọn nhân viên: ");
            int chonNV = int.Parse(Console.ReadLine());
            while (true)
            {
                if (chonNV > -1 && chonNV < nhanVienDAL.LayDSNhanVien().Count) break;
                Console.Write("Nhân viên không tồn tại: ");
                chonNV = int.Parse(Console.ReadLine());
            }
            NhanVien nhanVien = nhanVienDAL.LayDSNhanVien()[chonNV];
            HDB.Manv = nhanVien.Manv;
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            KhachHangDAL khachHangDAL = new KhachHangDAL();
            khachHangBLL.HienDSKhachHang();
            Console.WriteLine("Chọn khách hàng: ");
            int chonKH = int.Parse(Console.ReadLine());
            while (true)
            {
                if (chonKH > -1 && chonKH < khachHangDAL.LayDSKhachHang().Count) break;
                Console.Write("Khach hàng không tồn tại: ");
                chonKH = int.Parse(Console.ReadLine());
            }
            KhachHang khachHang = khachHangDAL.LayDSKhachHang()[chonKH];
            HDB.Makh= khachHang.Makh;
            Console.Write("Nhập ngày bán(ngày/tháng/năm): ");
            HDB.Ngayban = Console.ReadLine();
            ChiTietHDBBLL chiTietHDBBLL = new ChiTietHDBBLL();
            chiTietHDBBLL.ThemChiTietHDB(HDB.Mahd);
            return HDB;
        }
        public void ThemHoaDonBan()
        {
            Console.WriteLine("Thêm hóa đơn bán");
            HoaDonBan hoaDonBan = NhapHDB();
            hoaDonBanList.Add(hoaDonBan);
            hoaDonBanDAL.GhiFile(hoaDonBanList);
            Console.WriteLine("Thêm hóa đơn bán thành công");
        }
        public void HienHoaDonBan(HoaDonBan hoaDonBan,int stt)
        {
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            KhachHang khachHang = khachHangBLL.khachHang(hoaDonBan.Makh);
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            NhanVien nhanVien = nhanVienBLL.nhanVien(hoaDonBan.Manv);
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|",stt, hoaDonBan.Mahd, hoaDonBan.Ngayban, khachHang.Hoten, nhanVien.Hoten);
        }
        public void HienDSHoaDonBan()
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "STT", "Mã hóa đơn", "Ngày bán", "Khách hàng mua", "Nhân viên bán");
            int stt = 0;
            foreach(HoaDonBan hoaDonBan in hoaDonBanList)
            {
                HienHoaDonBan(hoaDonBan, stt);
                stt++;
            }
            //viết 1 hàm để xem chi tiết hóa đơn bán
            Console.WriteLine("Chọn hóa đơn muốn xem: ");
            int chon = int.Parse(Console.ReadLine());
            if (chon > -1 && chon < hoaDonBanList.Count)
            {
                HoaDonBan hoaDonBan = hoaDonBanList[chon];
                ChiTietHDBBLL chiTietHDBBLL = new ChiTietHDBBLL();
                chiTietHDBBLL.HienDSCTHDB(hoaDonBan.Mahd);
            }
        }

    }
}
