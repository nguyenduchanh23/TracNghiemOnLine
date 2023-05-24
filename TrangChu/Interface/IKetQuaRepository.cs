using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TrangChu.Models;

namespace TrangChu.Interface
{
    public interface IKetQuaRepository
    {
        Task<KetQua> Add(KetQua data);
        Task<IEnumerable<KetQuaTrinhDien>> Get(KetQuaTrinhDien data);
        Task<IEnumerable<KetQuaTrinhDien>> GetByMaSV(string maSV);
    }
}