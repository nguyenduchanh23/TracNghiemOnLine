using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTTNTT.Controllers
{
    [Authorize]
    public class SinhVienController : Controller
    {
        // GET: SinhVien
        public ActionResult QuanLySinhVien()
        {
            return View();
        }
    }
}