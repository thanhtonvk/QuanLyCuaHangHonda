using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.Entities
{
    class KhachHang
    {
        private string makh, hoten, ngaysinh, diachi, sdt;

        public KhachHang(string makh, string hoten, string ngaysinh, string diachi, string sdt)
        {
            this.makh = makh;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.sdt = sdt;
        }
        public KhachHang()
        {

        }
        override
        public string ToString()
        {
            return makh + "#" + hoten + "#" + ngaysinh + "#" + diachi + "#" + sdt;
        }
        public string Makh { get => makh; set => makh = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
