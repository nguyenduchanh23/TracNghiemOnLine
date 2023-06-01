using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TrangChu.Models;

namespace TrangChu.Interface
{
    public interface IThongBaoRepository
    {
        Task<IEnumerable<ThongBao>> GetsByMaSV(string maSV);
        Task<int> Deletes(string listID);
    }
}