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
    public class LoaiCauHoiApiController : ApiController
    {
        private readonly ILoaiCauHoiRepository _LoaiCauHoiRepository;
        public LoaiCauHoiApiController()
        {
            _LoaiCauHoiRepository = new LoaiCauHoiRepository();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Gets()
        {
            try
            {
                IEnumerable<LoaiCauHoi> lst = null;
                lst = await _LoaiCauHoiRepository.Gets();
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [HttpPost]
        public async Task<HttpResponseMessage> Add(LoaiCauHoi data)
        {
            try
            {
                LoaiCauHoi item = null;
                item = await _LoaiCauHoiRepository.Add(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Edit(LoaiCauHoi data)
        {
            try
            {
                LoaiCauHoi item = null;
                item = await _LoaiCauHoiRepository.Edit(data);
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
                item = await _LoaiCauHoiRepository.Delete(id);
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
                item = await _LoaiCauHoiRepository.Deletes(listID);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Check(LoaiCauHoiCheck data)
        {
            try
            {
                int item = await _LoaiCauHoiRepository.Check(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}