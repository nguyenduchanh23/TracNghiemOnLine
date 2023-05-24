using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTTNTT.Controllers
{
    [Authorize]
    public class HocPhanController : Controller
    {
        // GET: HocPhan
        public ActionResult QuanLyHocPhan()
        {
            return View();
        }
    }
}