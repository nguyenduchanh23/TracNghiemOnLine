using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrangChu.Models
{
    public class HocPhan
    {
        public int HocPhanID { get; set; }
        public string TenHocPhan { get; set; }
        public string MaHocPhan { get; set; }
        public  string MoTa { get; set; }
    }

    public class HocPhanCheck
    {
        public int HocPhanID { get; set; }
        public string MaHocPhan { get; set; }
    }
}