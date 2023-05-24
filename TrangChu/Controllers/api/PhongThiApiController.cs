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
    public class PhongThiApiController : ApiController
    {
        private readonly IDeThiRepository _Repository;
        private readonly IDapAnRepository _DapAnRepository;
        public PhongThiApiController()
        {
            _Repository = new DeThiRepository();
            _DapAnRepository = new DapAnRepository();
        }
       

        [HttpPost]
        public async Task<HttpResponseMessage> CheckMaVaoThi(string ma)
        {
            try
            {
                int item = await _Repository.CheckMaVaoThi(ma);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> GetByMSV(string id)
        {
            try
            {
                IEnumerable<DeThiTrinhDien> item = null;
                item = await _Repository.GetByMSV(id);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> GetByID(int id)
        {
            try
            {
                DeThiTrinhDien item = null;
                item = await _Repository.GetByID(id);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> DeThi_CauHoi_GetByID(int deThiID)
        {
            try
            {
                IEnumerable<DeThi_CauHoi_TrinhDien> list = null;
                list = await _Repository.DeThi_CauHoi_GetByID(deThiID);
                return Request.CreateResponse(HttpStatusCode.OK, list, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> GetsDapAnByID(int id)
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

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> DongDeThi(int deThiID)
        {
            try
            {
                int item = await _Repository.DongDeThi(deThiID);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}