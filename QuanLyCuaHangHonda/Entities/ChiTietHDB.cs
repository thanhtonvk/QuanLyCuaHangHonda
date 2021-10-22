using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.Entities
{
    class ChiTietHDB
    {
        private string macthd, mahd, masp;
        private int soluong;

        public ChiTietHDB(string macthd, string mahd, string masp, int soluong)
        {
            this.macthd = macthd;
            this.mahd = mahd;
            this.masp = masp;
            this.soluong = soluong;
        }
        public ChiTietHDB()
        {

        }
        public string ToString()
        {
            return macthd + "#" + mahd + "#" + masp + "#" + soluong;
        }
        public string Macthd { get => macthd; set => macthd = value; }
        public string Mahd { get => mahd; set => mahd = value; }
        public string Masp { get => masp; set => masp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
