using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.Entities
{
     class SanPham
    {
        private string masp, tensp, thongso, mausac;
        private int giaban,khuyenmai,soluong;

        public SanPham()
        {
            soluong = 0;
        }

        public SanPham(string masp, string tensp, string thongso, string mausac, int giaban, int khuyenmai,int soluong)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.thongso = thongso;
            this.mausac = mausac;
            this.giaban = giaban;
            this.khuyenmai = khuyenmai;
            this.soluong = soluong;
        }

        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public string Thongso { get => thongso; set => thongso = value; }
        public string Mausac { get => mausac; set => mausac = value; }
        public int Giaban { get => giaban; set => giaban = value; }
        public int Khuyenmai { get => khuyenmai; set => khuyenmai = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        override
        public string ToString()
        {
            return Masp + "#" + Tensp + "#" + Thongso + "#" + Mausac + "#" + Giaban + "#" + Khuyenmai+"#"+soluong;
        }

    }
}
