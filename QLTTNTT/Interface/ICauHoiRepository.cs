using QLTTNTT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace QLTTNTT.Interface
{
    public interface ICauHoiRepository
    {
        Task<IEnumerable<CauHoiTrinhDien>> Gets();
        Task<CauHoi> Add(CauHoi data);
        Task<CauHoi> Edit(CauHoi data);
        Task<int> Delete(int id);
        Task<int> Deletes(string listID);

        Task<IEnumerable<CauHoiTrinhDien>> Filter(Filter data);
        Task<IEnumerable<CauHoi>> GetsByHocPhanID(CauHoi data);
    }
}