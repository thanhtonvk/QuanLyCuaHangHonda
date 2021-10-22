using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.Entities
{
    class ChiTietHDB
    {
        private string macthd, mahd, masp, soluong;

        public ChiTietHDB(string macthd, string mahd, string masp, string soluong)
        {
            this.macthd = macthd;
            this.mahd = mahd;
            this.masp = masp;
            this.soluong = soluong;
        }
        public ChiTietHDB()
        {

        }

        public string Macthd { get => macthd; set => macthd = value; }
        public string Mahd { get => mahd; set => mahd = value; }
        public string Masp { get => masp; set => masp = value; }
        public string Soluong { get => soluong; set => soluong = value; }
    }
}
