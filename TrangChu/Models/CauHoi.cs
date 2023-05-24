using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrangChu.Models
{
    public class CauHoi
    {
        public int CauHoiID { get; set; }
        public string NoiDung { get; set; }
        public int HocPhanID { get; set; }
        public DateTime NgayTao { get; set; }
        public int MucDo { get; set; }
        public int LoaiID { get; set; }

    }

    public class CauHoiTrinhDien
    {

        public int CauHoiID { get; set; }
        public string NoiDung { get; set; }
        public int HocPhanID { get; set; }
        public DateTime NgayTao { get; set; }
        public int MucDo { get; set; }
        public int LoaiID { get; set; }

        public string TenHocPhan { get; set; }
        public string MaHocPhan { get; set; }
        public string TenLoai { get; set; }
    }

    public class Filter { 
        public int HocPhanID { get; set; }
        public int LoaiID { get; set; }
        public int MucDo { get; set; }
    }

}