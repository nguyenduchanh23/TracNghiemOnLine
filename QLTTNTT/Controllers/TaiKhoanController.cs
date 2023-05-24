using QLTTNTT.Controllers.api;
using QLTTNTT.Models;
using QLTTNTT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace QLTTNTT.Controllers
{
    [Authorize]
    public class TaiKhoanController : Controller
    {
        // GET: TaiKhoan
        public ActionResult QuanLyTaiKhoan()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult DangNhap()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Authorize(string login = "")
        {
            if(login != "")
            {
                var cookieValue = Newtonsoft.Json.JsonConvert.SerializeObject(login);
                FormsAuthentication.SetAuthCookie(cookieValue, false);
                return RedirectToAction("Index", "ThongKe");
            }
            return View("DangNhap");
        }

        [Authorize]
        public ActionResult DangXuat()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("DangNhap");
        }
    }
}