using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.Entities
{
    class HoaDonNhap
    {
        private string mahd, manv, ngay;

        public HoaDonNhap(string mahd, string manv, string ngay)
        {
            this.Mahd = mahd;
            this.Manv = manv;
            this.Ngay = ngay;
        }
        public HoaDonNhap()
        {

        }
        override
        public string ToString()
        {
            return mahd + "#" + manv + "#" + ngay;
        }
        public string Mahd { get => mahd; set => mahd = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Ngay { get => ngay; set => ngay = value; }
    }
}
