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
    public class ThongBaoApiController : ApiController
    {
        private readonly IThongBaoRepository _Repository;
        public ThongBaoApiController()
        {
            _Repository = new ThongBaoRepository();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> GetsByMaSV(string maSV)
        {
            try
            {
                IEnumerable<ThongBao> lst = null;
                lst = await _Repository.GetsByMaSV(maSV);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [HttpDelete]
        public async Task<HttpResponseMessage> Deletes(string listID)
        {
            try
            {
               int item = await _Repository.Deletes(listID);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}