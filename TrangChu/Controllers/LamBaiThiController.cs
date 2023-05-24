using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrangChu.Controllers
{
    [Authorize]
    public class LamBaiThiController : Controller
    {
        // GET: LamBaiThi
        public ActionResult Thi(string id = "")
        {
            ViewBag.DeThiID = id;
            return View();
        }
        public ActionResult KetQua(string dethiID="", string masv = "")
        {
            if(dethiID != "" && masv != "")
            {
                ViewBag.DeThiID = dethiID;
                ViewBag.MaSV = masv;
            }
            return View();
        }
    }
}