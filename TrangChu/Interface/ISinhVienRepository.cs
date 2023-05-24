using TrangChu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrangChu.Interface
{
    public interface ISinhVienRepository
    {
        Task<IEnumerable<SinhVien>> Gets();
        Task<SinhVien> Add(SinhVien data);
        Task<SinhVien> Edit(SinhVien data);
        Task<int> Delete(int id);
        Task<int> Deletes(string listID);
        Task<int> Check(SinhVienCheck data);

        Task<SinhVien> GetByID(string id);
    }
}