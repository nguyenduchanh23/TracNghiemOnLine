using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLTTNTT.Models
{
    public class SinhVien
    {
        public int SinhVienID { get; set; }
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public int GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }
        public int TrangThai { get; set; }
    }
    public class SinhVienCheck
    {
        public int SinhVienID { get; set; }
        public string MaSinhVien { get; set; }
    }
}