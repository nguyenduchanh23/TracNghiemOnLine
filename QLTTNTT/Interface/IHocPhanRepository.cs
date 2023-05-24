using QLTTNTT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace QLTTNTT.Interface
{
    public interface IHocPhanRepository
    {
        Task<IEnumerable<HocPhan>> Gets(Search data);
        Task<HocPhan> Add(HocPhan data);
        Task<HocPhan> Edit(HocPhan data);

        Task<int> Delete(int id);
        Task<int> Deletes(string listID);
        Task<int> Check(HocPhanCheck data);
    }
}