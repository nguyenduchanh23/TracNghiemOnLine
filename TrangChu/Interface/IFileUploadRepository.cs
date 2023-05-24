using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrangChu.Interface
{
    internal interface IFileUploadRepository
    {
        bool DeleteFiles(string pathFolder, string filename);
    }
}