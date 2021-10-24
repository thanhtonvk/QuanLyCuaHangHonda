using QuanLyCuaHangHonda.DAL;
using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.BLL
{
    class KhachHangBLL
    {
        List<KhachHang> khachHangList;
        KhachHangDAL khachHangDAL;
        Random random;
        public KhachHangBLL()
        {
            khachHangDAL = new KhachHangDAL();
            khachHangList = khachHangDAL.LayDSKhachHang();
            random = new Random();
        }
        public KhachHang NhapKhachHang()
        {
            KhachHang khachHang = new KhachHang();
            khachHang.Makh = "KH" + random.Next();
            Console.WriteLine("Nhập họ tên: ");
            khachHang.Hoten = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh: ");
            khachHang.Ngaysinh = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ: ");
            khachHang.Diachi = Console.ReadLine();
            Console.WriteLine("Nhập SĐT: ");
            khachHang.Sdt = Console.ReadLine();
            return khachHang;
        }
        public void ShowKhachHang(KhachHang khachHang, int index)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", index, khachHang.Makh, khachHang.Hoten, khachHang.Ngaysinh, khachHang.Diachi, khachHang.Sdt);
        }
        public void HienDSKhachHang()
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "STT", "Mã khách hàng", "Họ tên", "Ngày sinh", "Địa chỉ", "SĐT");
            foreach (KhachHang khachHang in khachHangList)
            {
                ShowKhachHang(khachHang, khachHangList.IndexOf(khachHang));
            }
        }
        public void ThemKhachHang()
        {
            while (true)
            {
                KhachHang khachHang = NhapKhachHang();
                khachHangList.Add(khachHang);
                khachHangDAL.GhiFile(khachHangList);
                Console.WriteLine("Bạn muốn nhập tiếp không? C/K");
                string chon = Console.ReadLine();
                if (chon == "k" || chon == "K") break;
            }
        }
        public void CapNhatKhachHang()
        {
            HienDSKhachHang();
            Console.Write("Chọn: ");
            int chon = int.Parse(Console.ReadLine());
            KhachHang khachHang = khachHangList[chon];
            Console.WriteLine("Nhập họ tên: ");
            khachHang.Hoten = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh: ");
            khachHang.Ngaysinh = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ: ");
            khachHang.Diachi = Console.ReadLine();
            Console.WriteLine("Nhập SĐT: ");
            khachHang.Sdt = Console.ReadLine();
            khachHangList[chon] = khachHang;
            Console.WriteLine("Cập nhật thành công");
            khachHangDAL.GhiFile(khachHangList);
        }
        public void XoaThongTin()
        {

            HienDSKhachHang();
            Console.Write("Chọn: ");
            int chon = int.Parse(Console.ReadLine());
            khachHangList.RemoveAt(chon);
            Console.WriteLine("Xóa thành công");
            khachHangDAL.GhiFile(khachHangList);
        }
        public void timKhachHang()
        {
            Console.Write("Nhập từ khóa cần tìm: ");
            string tukhoa = Console.ReadLine();
            int dem = 0;
            foreach (KhachHang khachHang in khachHangList)
            {

                if (khachHang.Makh.ToLower().Contains(tukhoa.ToLower()) ||
                    khachHang.Hoten.ToLower().Contains(tukhoa.ToLower()) ||
                    khachHang.Ngaysinh.ToLower().Contains(tukhoa.ToLower()) ||
                    khachHang.Diachi.ToLower().Contains(tukhoa.ToLower()))
                {
                    ShowKhachHang(khachHang, dem);
                    dem++;
                }
            }
        }
        public KhachHang khachHang(string manv)
        {
            KhachHang kq = null;
            foreach (KhachHang khachHang in khachHangList)
            {
                if (khachHang.Makh.Equals(manv)) kq = khachHang;
            }
            return kq;
        }
    }
}
