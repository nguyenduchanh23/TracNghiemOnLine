using TrangChu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrangChu.Interface
{
    public interface IDapAnRepository
    {
        Task<DapAn> Add(DapAn data);
        Task<DapAn> Edit(DapAn data);
        Task<IEnumerable<DapAn>> GetsByID(int id);
        Task<IEnumerable<DapAn>> GetByID_Dung(int id); 
        Task<IEnumerable<DapAn>> GetByID_Sai(int id);
        Task<int> Delete(int id);
      
    }
}