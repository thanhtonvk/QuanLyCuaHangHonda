using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.DAL
{
    class HoaDonNhapDAL
    {
        string path = "HoaDonNhap.txt";
        public List<HoaDonNhap> LayDSHoaDonNhap()
        {
            List<HoaDonNhap> sanPhamList = new List<HoaDonNhap>();
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    HoaDonNhap hoaDonNhap = new HoaDonNhap(arr[0], arr[1], arr[2]);
                    sanPhamList.Add(hoaDonNhap);
                }
                streamReader.Close();
            }
            return sanPhamList;
        }
        public void GhiFile(List<HoaDonNhap> sanPhamList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (HoaDonNhap hoaDonNhap in sanPhamList)
            {
                streamWriter.WriteLine(hoaDonNhap.ToString());
            }
            streamWriter.Close();
        }
    }
}
