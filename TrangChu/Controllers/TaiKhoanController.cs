using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace TrangChu.Controllers
{
    [Authorize]
    public class TaiKhoanController : Controller
    {
        // GET: TaiKhoan
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult CheckLogin(string name = "", string masv = "")
        {
            if (name != "")
            {
                Session["MaSV"] = masv;
                Session["User"] = name;
                var cookieValue = Newtonsoft.Json.JsonConvert.SerializeObject(name);
                FormsAuthentication.SetAuthCookie(cookieValue, false);
                return RedirectToAction("Index", "Home");
            }
            return View("Login");
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }
        [Authorize]
        public ActionResult ThongTinCaNhan(string id="")
        {
            if (id != "")
            {
                ViewBag.id = id;
            }
            return View();
        }
    }
}