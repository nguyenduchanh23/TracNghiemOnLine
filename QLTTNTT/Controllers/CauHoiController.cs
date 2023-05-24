using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTTNTT.Controllers
{
    [Authorize]
    public class CauHoiController : Controller
    {
        // GET: CauHoi
        public ActionResult QuanLyCauHoi()
        {
            return View();
        }
    }
}