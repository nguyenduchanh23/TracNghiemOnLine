using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Tesst.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        //private List<Users> AllUser()
        //{
        //    List<Users> list = new List<Users>();
        //    for (int i = 1; i < 6; i++)   // Tạo ra 6 User
        //    {
        //        Users u = new Users()   // Tạo ra user mới
        //        {
        //            Username = $"user {i}",
        //            Password = $"password {i}",
        //            Fullname = $"fullname {i}",
        //            IsActive = true
        //        };
        //        list.Add(u);   // Thêm vào danh sách User
        //    }
        //    return list;
        //}

        //// GET api/User/GetAllUser
        //[HttpGet] // Cho phép truy cập với phương thức là GET
        //public HttpResponseMessage GetAllUser()
        //{
        //    var list = AllUser();
        //    if (list != null)
        //        return Request.CreateResponse(HttpStatusCode.OK, list);
        //    else return Request.CreateResponse(HttpStatusCode.NotFound);
        //}
    }
}