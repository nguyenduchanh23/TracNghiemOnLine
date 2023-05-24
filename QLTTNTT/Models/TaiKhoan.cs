using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLTTNTT.Models
{
    public class TaiKhoan
    {
        public int TaiKhoanID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Quyen { get; set; }
        public int TrangThai { get; set; }
        public string Password_Random { get; set; }
    }

    public class TaiKhoanCheck
    {
        public int TaiKhoanID { get; set; }
        public string Username { get; set; }
        public string Password_Random { get; set; }
    }

}