using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.Entities
{
    class ChiTietHDN
    {
        private int dongia;
        private string macthdn;
        private string mahdn;
        private string masp;
        private int soluong;

     
        public ChiTietHDN()
        {

        }

        public ChiTietHDN( string macthdn, string mahdn, string masp, int soluong, int dongia)
        {
            this.dongia = dongia;
            this.macthdn = macthdn;
            this.mahdn = mahdn;
            this.masp = masp;
            this.soluong = soluong;
        }

        public int Dongia { get => dongia; set => dongia = value; }
        public string Macthdn { get => macthdn; set => macthdn = value; }
        public string Mahdn { get => mahdn; set => mahdn = value; }
        public string Masp { get => masp; set => masp = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        override
            public string ToString()
        {
            return Macthdn + "#" + Mahdn + "#" + Masp + "#" + Soluong + "#" + Dongia;
        }

    }
}
