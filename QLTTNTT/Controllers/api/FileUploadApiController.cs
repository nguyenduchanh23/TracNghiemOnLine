using QLTTNTT.Interface;
using QLTTNTT.Models;
using QLTTNTT.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace QLTTNTT.Controllers.api
{
    [AllowAnonymous]
    public class FileUploadApiController : ApiController
    {
        private readonly IFileUploadRepository _repository;
        public FileUploadApiController()
        {
            _repository = new FileUploadRepository();
        }

        [HttpPost]
        public ApiResult<List<FileUploadModel>> UploadFiles(string pathFolder, string pathThuMuc)
        {
            HttpFileCollection files = HttpContext.Current.Request.Files;
            List<FileUploadModel> filesUrls = new List<FileUploadModel>();

            try
            {
                for (var i = 0; i < files.Count; i++)
                {
                    HttpPostedFile file = files[i];
                    // files folder
                    var savePath = HttpContext.Current.Server.MapPath(pathFolder);
                    if (!Directory.Exists(savePath))
                        Directory.CreateDirectory(savePath);

                    string originname = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(savePath, originname);
                    file.SaveAs(_path);
                    //// UserF:\Picture\Unflash
                    string _pathUser = Path.Combine(@"F:\LapTrinh\ASP.Net\KhoaLuanTotNghiep\QLTTNTT\TrangChu\FileUpload\SinhVien", originname);
                    file.SaveAs(_pathUser);
                    Uri baseuri = new Uri(Request.RequestUri.AbsoluteUri.Replace(Request.RequestUri.PathAndQuery, string.Empty));
                    var thuMuc = pathThuMuc;
                    var fileBase = $"{thuMuc}/{originname}";

                    FileUploadModel item = new FileUploadModel
                    {
                        ViTri = fileBase,
                        Ten = originname,
                        KichThuoc = file.ContentLength,
                        KieuMoRong = file.ContentType,
                    };

                    filesUrls.Add(item);
                }

                return new ApiSuccessResult<List<FileUploadModel>>(filesUrls, "Upload file thành công!");
            }
            catch (Exception ex)
            {
                throw ex;
                //return new ApiErrorResult<List<FileUploadModel>>("Upload file thất bại!");
            }
        }

        [HttpPost]
        public ApiResult<bool> DeleteFile(string pathFolder, string filename)
        {
            try
            {
                // files folder
                var savePath = HttpContext.Current.Server.MapPath(pathFolder);
                var _path = Path.Combine(savePath, filename);
                if (System.IO.File.Exists(_path))
                {
                    System.IO.File.Delete(_path);
                }

                return new ApiSuccessResult<bool>(true, "Xóa file đính kèm thành công!");
            }
            catch (Exception)
            {
                return new ApiErrorResult<bool>("Xóa file đính kèm thất bại!"); ;
            }
        }
    }
}