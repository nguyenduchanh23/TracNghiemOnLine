using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using TrangChu.Interface;
using TrangChu.Models;
using TrangChu.Repository;

namespace TrangChu.Controllers.api
{
    public class TaiKhoanApiController : ApiController
    {
        private readonly ITaiKhoanRepository _repository;
        public TaiKhoanApiController()
        {
            _repository = new TaiKhoanRepository();
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Login(TaiKhoan data)
        {
            try
            {
                TaiKhoan item = await _repository.CheckLogin(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}