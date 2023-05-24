using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TrangChu.Interface;
using TrangChu.Models;
using TrangChu.Repository;

namespace TrangChu.Controllers.api
{
    public class SinhVienApiController : ApiController
    {
        private readonly ISinhVienRepository _repository;
        public SinhVienApiController()
        {
            _repository = new SinhVienRepository();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> GetByID(string id)
        {
            try
            {
                SinhVien lst = null;
                lst = await _repository.GetByID(id);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}