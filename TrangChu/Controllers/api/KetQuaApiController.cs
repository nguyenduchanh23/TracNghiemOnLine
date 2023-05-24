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
    public class KetQuaApiController : ApiController
    {
        private readonly IKetQuaRepository _KetQuaRepository;
        public KetQuaApiController()
        {
            _KetQuaRepository = new KetQuaRepository();
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Add(KetQua data)
        {
            try
            {
                KetQua item = null;
                item = await _KetQuaRepository.Add(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Get(KetQuaTrinhDien data)
        {
            try
            {
                IEnumerable<KetQuaTrinhDien> item = await _KetQuaRepository.Get(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> GetByMaSV(string maSV)
        {
            try
            {
                IEnumerable<KetQuaTrinhDien> list = await _KetQuaRepository.GetByMaSV(maSV);
                return Request.CreateResponse(HttpStatusCode.OK, list, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}