using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTTNTT.Controllers
{
    [Authorize]
    public class LoaiCauHoiController : Controller
    {
        // GET: LoaiCauHoi
        public ActionResult QuanLyLoaiCauHoi()
        {
            return View();
        }
    }
}