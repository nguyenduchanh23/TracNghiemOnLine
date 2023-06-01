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
    public class DeThiApiController : ApiController
    {
        private readonly IDeThiRepository _DeThiRepository;
        public DeThiApiController()
        {
            _DeThiRepository = new DeThiRepository();
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Gets()
        {

            try
            {
                IEnumerable<DeThiTrinhDien> lst = null;
                lst = await _DeThiRepository.Gets();
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Filter(DeThi_Filter data)
        { 
            try
            {
                IEnumerable<DeThiTrinhDien> lst = null;
                lst = await _DeThiRepository.Filter(data);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
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
                item = await _DeThiRepository.GetByID(id);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [HttpPost]
        public async Task<HttpResponseMessage> Add(DeThi data)
        {
            try
            {
                DeThi item = null;
                item = await _DeThiRepository.Add(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Edit(DeThi data)
        {
            try
            {
                DeThi item = null;
                item = await _DeThiRepository.Edit(data);
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
                item = await _DeThiRepository.Delete(id);
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
                item = await _DeThiRepository.Deletes(listID);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        #region DeThi_CauHoi
        [HttpPost]
        public async Task<HttpResponseMessage> DeThi_CauHoi_Add(DeThi_CauHoi data)
        {
            try
            {
                DeThi_CauHoi item = null;
                item = await _DeThiRepository.DeThi_CauHoi_Add(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [HttpPost]
        public async Task<HttpResponseMessage> DeThi_CauHoi_GetByID(int deThiID)
        {
            try
            {
                IEnumerable<DeThi_CauHoi_TrinhDien> list = null;
                list = await _DeThiRepository.DeThi_CauHoi_GetByID(deThiID);
                return Request.CreateResponse(HttpStatusCode.OK, list, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [HttpDelete]
        public async Task<HttpResponseMessage> DeThi_CauHoi_Delete(int id)
        {
            try
            {
                int item = 0;
                item = await _DeThiRepository.DeThi_CauHoi_Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        #endregion
        #region DeThi_SinhVien
        [HttpPost]
        public async Task<HttpResponseMessage> DeThi_SinhVien_Add(DeThi_SinhVien data)
        {
            try
            {
                DeThi_SinhVien item = null;
                item = await _DeThiRepository.DeThi_SinhVien_Add(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        public async Task<HttpResponseMessage> DeThi_SinhVien_GetByID(int deThiID)
        {
            try
            {
                IEnumerable<DeThi_SinhVien> list = null;
                list = await _DeThiRepository.DeThi_SinhVien_GetByID(deThiID);
                return Request.CreateResponse(HttpStatusCode.OK, list, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [HttpDelete]
        public async Task<HttpResponseMessage> DeThi_SinhVien_Delete(int id)
        {
            try
            {
                int item = 0;
                item = await _DeThiRepository.DeThi_SinhVien_Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        #endregion

        #region ThongBao
        [HttpPost]
        public async Task<HttpResponseMessage> ThongBao(ThongBao data)
        {
            try
            {
                ThongBao item = null;
                item = await _DeThiRepository.ThongBao(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        #endregion
        #region LichSu
        [HttpPost]
        public async Task<HttpResponseMessage> GetsLichSu()
        {
            try
            {
                IEnumerable<DeThiTrinhDien> item = null;
                item = await _DeThiRepository.GetsLichSu();
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        #endregion
    }
}