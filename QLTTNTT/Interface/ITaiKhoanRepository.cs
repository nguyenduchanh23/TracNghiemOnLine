using QLTTNTT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace QLTTNTT.Interface
{
    public interface ITaiKhoanRepository
    {
        Task<IEnumerable<TaiKhoan>> Gets();
        Task<TaiKhoan> Add(TaiKhoan data);
        Task<TaiKhoan> DoiTrangThai(TaiKhoan data);
        Task<int> Delete(int id);
        Task<int> Deletes(string listID);
        Task<int> Check(TaiKhoanCheck data);
        /// <summary> Add_Excel
        /// Thêm thủ công trong quản lý sinh viên
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<TaiKhoan> Add_Excel(TaiKhoan data);
        Task<TaiKhoan> DoiMatKhau(TaiKhoan data);
        Task<TaiKhoan> Authorize(TaiKhoan data);

    }
}