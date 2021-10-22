using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.DAL
{
    class ChiTietHDNDAL
    
   {
        string path = "ChiTietHDN.txt";
        public List<ChiTietHDN> LayDSChiTietHDN()
        {
            List<ChiTietHDN> sanPhamList = new List<ChiTietHDN>();
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    ChiTietHDN chiTietHDN = new ChiTietHDN(arr[0], arr[1], arr[2],int.Parse(arr[3]),int.Parse(arr[4]));
                    sanPhamList.Add(chiTietHDN);
                }
                streamReader.Close();
            }
            return sanPhamList;
        }
        public void GhiFile(List<ChiTietHDN> sanPhamList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (ChiTietHDN chiTietHDN in sanPhamList)
            {
                streamWriter.WriteLine(chiTietHDN.ToString());
            }
            streamWriter.Close();
        }
    }
}
