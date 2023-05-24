using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLTTNTT.Models
{
    public class LoaiCauHoi
    {
        public int LoaiID { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
    }

    public class LoaiCauHoiCheck 
    {
        public int LoaiID { get; set; }
        public string TenLoai { get; set; }

    }
}