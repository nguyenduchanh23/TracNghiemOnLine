using TrangChu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrangChu.Interface
{
    public interface ITaiKhoanRepository
    {
        Task<TaiKhoan> DoiMatKhau(TaiKhoan data);
        Task<TaiKhoan> CheckLogin(TaiKhoan data);

    }
}