using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTTNTT.Controllers
{
    [Authorize]
    public class DeThiController : Controller
    {
        // GET: DeThi
        public ActionResult QuanLyDeThi()
        {
            return View();
        }

        public ActionResult ThemMoiDeThi()
        {
            return View();
        }

        public ActionResult ChinhSuaDeThi(int id)
        {
            ViewBag.DeThiID = id;
            return View();
        }
        public ActionResult ChiTietDeThi(int id)
        {
            ViewBag.DeThiID = id;
            return View();
        }
    }
}