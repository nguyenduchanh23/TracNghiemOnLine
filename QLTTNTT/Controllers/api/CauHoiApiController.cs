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
    public class CauHoiApiController : ApiController
    {
        
        private readonly ICauHoiRepository _CauHoiRepository;
        public CauHoiApiController()
        {
            _CauHoiRepository = new CauHoiRepository();
        }
       
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Gets()
        {

            try
            {
                IEnumerable<CauHoiTrinhDien> lst = null;
                lst = await _CauHoiRepository.Gets();
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [HttpPost]
        public async Task<HttpResponseMessage> Add(CauHoi data)
        {
            try
            {
                CauHoi item = null;
                item = await _CauHoiRepository.Add(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Edit(CauHoi data)
        {
            try
            {
                CauHoi item = null;
                item = await _CauHoiRepository.Edit(data);
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
                item = await _CauHoiRepository.Delete(id);
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
                item = await _CauHoiRepository.Deletes(listID);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Filter(Filter data)
        {

            try
            {
                IEnumerable<CauHoiTrinhDien> lst = null;
                lst = await _CauHoiRepository.Filter(data);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
       
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> GetsByHocPhanID(CauHoi data)
        {
            try
            {
                IEnumerable<CauHoi> lst = null;
                lst = await _CauHoiRepository.GetsByHocPhanID(data);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}