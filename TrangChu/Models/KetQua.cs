using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrangChu.Models
{
    public class KetQua
    {
        public int KetQuaID { get; set; }
        public int DeThiID { get; set; }
        public string MaSinhVien { get; set; }
        public float Diem { get; set; }
        public string ThoiGianLamBai { get; set; }
        public int SoCauHoiDung { get; set; }
    }
    public class KetQuaTrinhDien
    {
        public int KetQuaID { get; set; }
        public int DeThiID { get; set; }
        public string MaSinhVien { get; set; }
        public float Diem { get; set; }
        public string ThoiGianLamBai { get; set; }
        public int SoCauHoiDung { get; set; }
        public string TenHocPhan { get; set; }
        public string MaHocPhan { get; set; }
        public DateTime ThoiGian { get; set; }
        public string NoiDung { get; set; }
        public int SoCauHoi { get; set; }
    }
}