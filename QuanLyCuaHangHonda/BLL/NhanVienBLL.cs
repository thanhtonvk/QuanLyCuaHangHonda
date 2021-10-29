using QuanLyCuaHangHonda.DAL;
using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.BLL
{
    class NhanVienBLL
    {
        public List<NhanVien> nhanVienList;
        NhanVienDAL nhanVienDAL;
        Random random;
        public NhanVienBLL()
        {
            nhanVienDAL = new NhanVienDAL();
            //đọc danh sách nhân viên trong file
            nhanVienList = nhanVienDAL.LayDSNhanVien();
            random = new Random();
        }
        public NhanVien NhapNhanVien()
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.Manv = "NV" + random.Next();
            Console.WriteLine("Nhập họ tên: ");
            nhanVien.Hoten = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh: ");
            nhanVien.Ngaysinh = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ: ");
            nhanVien.Diachi = Console.ReadLine();
            Console.WriteLine("Nhập SĐT: ");
            nhanVien.Sdt = Console.ReadLine();
            Console.WriteLine("Nhập giới tính: ");
            nhanVien.Gioitinh = Console.ReadLine();
            Console.WriteLine("Nhập lương: ");
            nhanVien.Luong = Console.ReadLine();
            Console.WriteLine("Nhập chức vụ: ");
            nhanVien.Chucvu = Console.ReadLine();
            return nhanVien;
        }
        public void ShowNhanVien(NhanVien nhanVien, int index)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|{8,-20}|", index, nhanVien.Manv, nhanVien.Hoten, nhanVien.Ngaysinh, nhanVien.Diachi, nhanVien.Sdt, nhanVien.Gioitinh, nhanVien.Luong, nhanVien.Chucvu);
        }
        public void HienDSNhanVien()
        {
            Console.Clear();
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|{8,-20}|", "STT", "Mã nhân viên", "Họ tên", "Ngày sinh", "Địa chỉ", "SĐT", "Giới tính", "Lương", "Chức vụ");
            foreach (NhanVien nhanVien in nhanVienList)
            {
                ShowNhanVien(nhanVien, nhanVienList.IndexOf(nhanVien));
            }
        }
        public void ThemNhanVien()
        {
            while (true)
            {
                Console.Clear();
                NhanVien nhanVien = NhapNhanVien();
                nhanVienList.Add(nhanVien);
                nhanVienDAL.GhiFile(nhanVienList);
                Console.WriteLine("Bạn muốn nhập tiếp không? C/K");
                string chon = Console.ReadLine();
                if (chon == "k" || chon == "K") break;
            }
        }
        public void CapNhatNhanVien()
        {
            Console.Clear();
            HienDSNhanVien();
            Console.Write("Chọn: ");
            int chon = int.Parse(Console.ReadLine());
            if (chon > -1 && chon < nhanVienList.Count)
            {
                NhanVien nhanVien = nhanVienList[chon];
                Console.WriteLine("Nhập họ tên: ");
                nhanVien.Hoten = Console.ReadLine();
                Console.WriteLine("Nhập ngày sinh: ");
                nhanVien.Ngaysinh = Console.ReadLine();
                Console.WriteLine("Nhập địa chỉ: ");
                nhanVien.Diachi = Console.ReadLine();
                Console.WriteLine("Nhập SĐT: ");
                nhanVien.Sdt = Console.ReadLine();
                Console.WriteLine("Nhập giới tính: ");
                nhanVien.Gioitinh = Console.ReadLine();
                Console.WriteLine("Nhập lương: ");
                nhanVien.Luong = Console.ReadLine();
                Console.WriteLine("Nhập chức vụ: ");
                nhanVien.Chucvu = Console.ReadLine();
                nhanVienList[chon] = nhanVien;
                Console.WriteLine("Cập nhật thành công");
                nhanVienDAL.GhiFile(nhanVienList);
            }

        }
        public void XoaThongTin()
        {
            Console.Clear();

            HienDSNhanVien();
            Console.Write("Chọn: ");
            int chon = int.Parse(Console.ReadLine());
            if (chon > -1 && chon < nhanVienList.Count)
            {
                nhanVienList.RemoveAt(chon);
                Console.WriteLine("Xóa thành công");
                nhanVienDAL.GhiFile(nhanVienList);
            }

        }
        public void timNhanVien()
        {
            Console.Clear();
            Console.Write("Nhập từ khóa cần tìm: ");
            string tukhoa = Console.ReadLine();
            int dem = 0;
            foreach (NhanVien nhanVien in nhanVienList)
            {

                if (nhanVien.Manv.ToLower().Contains(tukhoa.ToLower()) ||
                    nhanVien.Hoten.ToLower().Contains(tukhoa.ToLower()) ||
                    nhanVien.Ngaysinh.ToLower().Contains(tukhoa.ToLower()) ||
                    nhanVien.Diachi.ToLower().Contains(tukhoa.ToLower()) ||
                    nhanVien.Gioitinh.ToLower().Contains(tukhoa.ToLower()) ||
                    nhanVien.Chucvu.ToLower().Contains(tukhoa.ToLower()))
                {
                    ShowNhanVien(nhanVien, dem);
                    dem++;
                }
            }
        }
        public NhanVien nhanVien(string manv)
        {
            NhanVien kq = null;
            foreach (NhanVien nhanVien in nhanVienList)
            {
                if (nhanVien.Manv.Equals(manv)) kq = nhanVien;
            }
            return kq;
        }
    }
}
