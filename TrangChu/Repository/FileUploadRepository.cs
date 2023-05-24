using TrangChu.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TrangChu.Repository
{
    public class FileUploadRepository : ConnectDatabase, IFileUploadRepository
    {
        public bool DeleteFiles(string pathFolder, string filename)
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

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}