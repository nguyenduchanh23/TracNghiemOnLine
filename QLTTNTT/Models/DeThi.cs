using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLTTNTT.Models
{
    public class DeThi
    {
        public int DeThiID { get; set; }
        public int HocPhanID { get; set; }
        public string NoiDung { get; set; }
        public int TrangThai { get; set; }
        public int SoCauHoi { get; set; }
        public DateTime ThoiGian { get; set; }
        public DateTime NgayTao { get; set; }
        public string ThoiLuongThi { get; set; }
        public string MaVaoThi { get; set; }
    }

    public class DeThiTrinhDien
    {
        public int DeThiID { get; set; }
        public int HocPhanID { get; set; }
        public string NoiDung { get; set; }
        public int TrangThai { get; set; }
        public int SoCauHoi { get; set; }
        public DateTime ThoiGian { get; set; }
        public DateTime NgayTao { get; set; }
        public string ThoiLuongThi { get; set; }
        public string MaVaoThi { get; set; }
        public string MaHocPhan { get; set; }
        public string TenHocPhan { get; set; }
    }
    public class DeThi_Filter
    {
        public int HocPhanID { get; set; }
        public int TrangThai { get; set; }
        public string ThoiGian { get; set; }
    }
    public class DeThi_CauHoi
    {
        public int ID { get; set; }
        public int DeThiID { get; set; }
        public int CauHoiID { get; set; }
    }
    public class DeThi_CauHoi_TrinhDien
    {
        public int ID { get; set; }
        public int DeThiID { get; set; }
        public int CauHoiID { get; set; }
        public string NoiDung { get; set; }
        public int MucDo { get; set; }
    }
    public class DeThi_SinhVien
    {
        public int ID { get; set; }
        public int DeThiID { get; set; }
        public string MaSinhVien { get; set; }
    }
    public class ThongBao
    {
        public int ID { get; set; }
        public int DeThiID { get; set; }
        public string MaSinhVien { get; set; }
        public string NoiDung { get; set; }
    }
}