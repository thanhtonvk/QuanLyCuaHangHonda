using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.DAL
{
     class HoaDonBanDAL
    {
        string path = "HoaDonBan.txt";
        public List<HoaDonBan> LayDSHoaDonBan()
        {
            List<HoaDonBan> sanPhamList = new List<HoaDonBan>();
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    HoaDonBan hoaDonBan = new HoaDonBan(arr[0], arr[1], arr[2],arr[3]);
                    sanPhamList.Add(hoaDonBan);
                }
                streamReader.Close();
            }
            return sanPhamList;
        }
        public void GhiFile(List<HoaDonBan> sanPhamList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (HoaDonBan hoaDonBan in sanPhamList)
            {
                streamWriter.WriteLine(hoaDonBan.ToString());
            }
            streamWriter.Close();
        }
    }
}
