using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.DAL
{
     class ChiTietHDBDAL
    {
        string path = "ChiTietHDB.txt";
        public List<ChiTietHDB> LayDSChiTietHDB()
        {
            List<ChiTietHDB> sanPhamList = new List<ChiTietHDB>();
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    ChiTietHDB chiTietHDB = new ChiTietHDB(arr[0], arr[1], arr[2], int.Parse(arr[3]));
                    sanPhamList.Add(chiTietHDB);
                }
                streamReader.Close();
            }
            return sanPhamList;
        }
        public void GhiFile(List<ChiTietHDB> sanPhamList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (ChiTietHDB chiTietHDB in sanPhamList)
            {
                streamWriter.WriteLine(chiTietHDB.ToString());
            }
            streamWriter.Close();
        }
    }
}
