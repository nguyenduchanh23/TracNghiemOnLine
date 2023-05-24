using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrangChu.Controllers
{
    [Authorize]
    public class LichSuThiController : Controller
    {
        // GET: KetQua
        public ActionResult LichSu()
        {
            return View();
        }
    }
}