using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.Entities
{
    class NhanVien
    {
        private string manv, hoten, ngaysinh, diachi, sdt, gioitinh, luong,chucvu;

        public NhanVien()
        {

        }
        public NhanVien(string manv, string hoten, string ngaysinh, string diachi, string sdt, string gioitinh, string luong, string chucvu)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.gioitinh = gioitinh;
            this.luong = luong;
            this.chucvu = chucvu;
        }
        override
        public string ToString()
        {
            return manv + "#" + hoten + "#" + ngaysinh + "#" + diachi + "#" + sdt + "#" + gioitinh + "#" + chucvu;
        }
        public string Manv { get => manv; set => manv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Luong { get => luong; set => luong = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
    }
}
