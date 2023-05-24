﻿using TrangChu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrangChu.Interface
{
    public interface IDeThiRepository
    {
        Task<IEnumerable<DeThiTrinhDien>> Gets();
        Task<IEnumerable<DeThiTrinhDien>> Filter(DeThi_Filter data);
        Task<DeThiTrinhDien> GetByID(int deThiID);

        Task<int> DongDeThi(int deThiID);
        #region DeThi_CauHoi
        Task<DeThi_CauHoi> DeThi_CauHoi_Add(DeThi_CauHoi data);
        Task<IEnumerable<DeThi_CauHoi_TrinhDien>> DeThi_CauHoi_GetByID(int deThiID);
        Task<int> DeThi_CauHoi_Delete(int id);
        #endregion

        #region DeThi_SinhVien
        Task<DeThi_SinhVien> DeThi_SinhVien_Add(DeThi_SinhVien data);
        Task<IEnumerable<DeThi_SinhVien>> DeThi_SinhVien_GetByID(int deThiID);
        Task<int> DeThi_SinhVien_Delete(int id);
        #endregion

        #region ThongBao
        Task<ThongBao> ThongBao(ThongBao data);
        #endregion

        #region PhongThi
        Task<IEnumerable<DeThiTrinhDien>> GetByMSV(string msv);
        Task<int> CheckMaVaoThi(string ma);
        #endregion
    }
}