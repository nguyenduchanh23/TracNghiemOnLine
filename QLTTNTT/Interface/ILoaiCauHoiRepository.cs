using QLTTNTT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace QLTTNTT.Interface
{
    public interface ILoaiCauHoiRepository
    {
        Task<IEnumerable<LoaiCauHoi>> Gets();
        Task<LoaiCauHoi> Add(LoaiCauHoi data);
        Task<LoaiCauHoi> Edit(LoaiCauHoi data);
        Task<int> Delete(int id);
        Task<int> Deletes(string listID);
        Task<int> Check(LoaiCauHoiCheck data);
    }
}