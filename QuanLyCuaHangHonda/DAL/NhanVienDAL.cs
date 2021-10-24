using QuanLyCuaHangHonda.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangHonda.DAL
{
    class NhanVienDAL
    {

        string path = "NhanVien.txt";
        public List<NhanVien> LayDSNhanVien()
        {
            List<NhanVien> nhanVienList = new List<NhanVien>();
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    NhanVien nhanVien = new NhanVien(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5],arr[6],arr[7]);
                    nhanVienList.Add(nhanVien);
                }
                streamReader.Close();
            }
            return nhanVienList;
        }
        public void GhiFile(List<NhanVien> nhanVienList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (NhanVien nhanVien in nhanVienList)
            {
                streamWriter.WriteLine(nhanVien.ToString());
            }
            streamWriter.Close();
        }
    }
}
