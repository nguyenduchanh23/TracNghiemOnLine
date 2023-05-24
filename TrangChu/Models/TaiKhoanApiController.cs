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
    public class TaiKhoanApiController : ApiController
    {
        private readonly ITaiKhoanRepository _TaiKhoanRepository;
        public TaiKhoanApiController()
        {
            _TaiKhoanRepository = new TaiKhoanRepository();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Gets()
        {
            try
            {
                IEnumerable<TaiKhoan> lst = null;
                lst = await _TaiKhoanRepository.Gets();
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [HttpPost]
        public async Task<HttpResponseMessage> Add(TaiKhoan data)
        {
            try
            {
                TaiKhoan item = null;
                item = await _TaiKhoanRepository.Add(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> DoiTrangThai(TaiKhoan data)
        {
            try
            {
                TaiKhoan item = null;
                item = await _TaiKhoanRepository.DoiTrangThai(data);
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
                item = await _TaiKhoanRepository.Delete(id);
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
                item = await _TaiKhoanRepository.Deletes(listID);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Check(TaiKhoanCheck data)
        {
            try
            {
                int item = await _TaiKhoanRepository.Check(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        /// <summary>
        /// Thêm thủ công trong quản lý tài khoản
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> Add_Excel(TaiKhoan data)
        {
            try
            {
                TaiKhoan item = null;
                item = await _TaiKhoanRepository.Add_Excel(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        public async Task<HttpResponseMessage> DoiMatKhau(TaiKhoan data)
        {
            try
            {
                TaiKhoan item = null;
                item = await _TaiKhoanRepository.DoiMatKhau(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Login(TaiKhoan data)
        {
            try
            {
                TaiKhoan item = await _TaiKhoanRepository.Authorize(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

    }
}