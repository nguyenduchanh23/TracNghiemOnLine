using QLTTNTT.Interface;
using QLTTNTT.Models;
using QLTTNTT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace QLTTNTT.Controllers.api
{
    [AllowAnonymous]
    public class HocPhanApiController : ApiController
    {
        private readonly IHocPhanRepository _HocPhanRepository;
        public HocPhanApiController()
        {
            _HocPhanRepository = new HocPhanRepository();
        }
        [HttpPost]
        public async Task<HttpResponseMessage> Gets(Search data)
        {
            try
            {
                IEnumerable<HocPhan> lst = null;
                lst = await _HocPhanRepository.Gets(data);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [HttpPost]
        public async Task<HttpResponseMessage> Add(HocPhan data)
        {
            try
            {
                HocPhan item = null;
                item = await _HocPhanRepository.Add(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Edit(HocPhan data)
        {
            try
            {
                HocPhan item = null;
                item = await _HocPhanRepository.Edit(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [HttpDelete]
        public async Task<HttpResponseMessage> Delete(int id)
        {
            try
            {
                int item = 0;
                item = await _HocPhanRepository.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
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
                int item = 0;
                item = await _HocPhanRepository.Deletes(listID);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Check(HocPhanCheck data)
        {
            try
            {
                int item = await _HocPhanRepository.Check(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}