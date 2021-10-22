using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.DAL
{
    class KhachHangDAL
    {

        string path = "KhachHang.txt";
        public List<KhachHang> LayDSKhachHang()
        {
            List<KhachHang> sanPhamList = new List<KhachHang>();
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    KhachHang khachHang = new KhachHang(arr[0], arr[1], arr[2], arr[3], arr[4]);
                    sanPhamList.Add(khachHang);
                }
                streamReader.Close();
            }
            return sanPhamList;
        }
        public void GhiFile(List<KhachHang> sanPhamList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (KhachHang khachHang in sanPhamList)
            {
                streamWriter.WriteLine(khachHang.ToString());
            }
            streamWriter.Close();
        }
    }
}
