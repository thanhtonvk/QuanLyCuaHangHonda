using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.DAL
{
    class SanPhamDAL
    {
        string path = "SanPham.txt";
        public List<SanPham> LayDSSanPham()
        {
            List<SanPham> sanPhamList = new List<SanPham>();
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    SanPham sanPham = new SanPham(arr[0], arr[1], arr[2], arr[3], int.Parse(arr[4]),int.Parse(arr[5]));
                    sanPhamList.Add(sanPham);
                }
                streamReader.Close();
            }
            return sanPhamList;
        }
        public void GhiFile(List<SanPham> sanPhamList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach(SanPham sanPham in sanPhamList)
            {
                streamWriter.WriteLine(sanPham.ToString());
            }
            streamWriter.Close();
        }
    }
}
