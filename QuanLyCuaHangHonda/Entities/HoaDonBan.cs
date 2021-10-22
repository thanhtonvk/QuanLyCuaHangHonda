using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.Entities
{
     class HoaDonBan
    {
        private string mahd, manv, makh, ngayban;

        public HoaDonBan(string mahd, string manv, string makh, string ngayban)
        {
            this.mahd = mahd;
            this.manv = manv;
            this.makh = makh;
            this.ngayban = ngayban;
        }
        public HoaDonBan()
        {

        }
        override
            public string ToString()
        {
            return mahd + "#" + manv + "#" + makh + "#" + ngayban;
        }
        public string Mahd { get => mahd; set => mahd = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Makh { get => makh; set => makh = value; }
        public string Ngayban { get => ngayban; set => ngayban = value; }
    }
}
