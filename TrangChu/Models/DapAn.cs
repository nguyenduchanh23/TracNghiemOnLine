using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrangChu.Models
{
    public class DapAn
    {
        public int DapAnID { get; set; }
        public int CauHoiID { get; set; }
        public string CauTraLoi { get; set; }
        public int DapAnDung { get; set; }
    }
}