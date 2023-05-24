using QLTTNTT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Tesst.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        //public async Task<ActionResult> Index(CauHoi data)
        //{
        //    ViewBag.Title = "Home Page";
        //    var list = await GetAllCauHoi();
        //    if (list != null) // Nếu list user khác null thì trả về View có chứa list
        //        return View(list);
        //    return View();
        //}

        //private async Task<List<CauHoi>> GetAllCauHoi()   // Hàm Gọi API trả về list user
        //{
        //    string baseUrl = Request.Url.Scheme + "://" + Request.Url.Authority +
        //        Request.ApplicationPath.TrimEnd('/') + "/";   // Lấy base uri của website
        //    using (var httpClient = new HttpClient())
        //    {
        //        HttpResponseMessage res = await httpClient.GetAsync(baseUrl + "api/CauHoi/Gets");
        //        if (res.StatusCode == System.Net.HttpStatusCode.OK)
        //        {
        //            List<CauHoi> list = new List<CauHoi>();
        //            list = res.Content.ReadAsAsync<List<CauHoi>>().Result;
        //            return list;
        //        }
        //        return null;
        //    }
        //}

        public ActionResult Index()
        {
            return View();
        }
    }
}
