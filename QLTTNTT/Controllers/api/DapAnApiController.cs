using QLTTNTT.Interface;
using QLTTNTT.Models;
using QLTTNTT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace QLTTNTT.Controllers.api
{
    public class DapAnApiController : ApiController
    {
        private readonly IDapAnRepository _DapAnRepository;
        public DapAnApiController()
        {
            _DapAnRepository = new DapAnRepository();
        }

       
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Add(DapAn data)
        {
            try
            {
                DapAn item = null;
                item = await _DapAnRepository.Add(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Edit(DapAn data)
        {
            try
            {
                DapAn item = null;
                item = await _DapAnRepository.Edit(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> GetByID_Dung(int id)
        {
            try
            {
                IEnumerable<DapAn> item = null;
                item = await _DapAnRepository.GetByID_Dung(id);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> GetByID_Sai(int id)
        {
            try
            {
                IEnumerable<DapAn> item = null;
                item = await _DapAnRepository.GetByID_Sai(id);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Delete(int id)
        {
            try
            {
                int item = await _DapAnRepository.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> GetsByID(int id)
        {
            try
            {
                IEnumerable<DapAn> item = null;
                item = await _DapAnRepository.GetsByID(id);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}