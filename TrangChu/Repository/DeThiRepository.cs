using Dapper;
using TrangChu.Interface;
using TrangChu.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TrangChu.Repository
{
    public class DeThiRepository : ConnectDatabase, IDeThiRepository
    {
        private readonly SqlConnection _conn;
        public DeThiRepository()
        {
            _conn = IConnectData();
        }

        public async Task<IEnumerable<DeThiTrinhDien>> Gets()
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    IEnumerable<DeThiTrinhDien> list = conn.Query<DeThiTrinhDien>("SP_TrangChu_DeThi_Gets", commandType: CommandType.StoredProcedure);
                    return list;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
        public async Task<IEnumerable<DeThiTrinhDien>> Filter(DeThi_Filter data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@HocPhanID", data.HocPhanID);
                    parameters.Add("@TrangThai", data.TrangThai);
                    parameters.Add("@ThoiGian", data.ThoiGian);
                    IEnumerable<DeThiTrinhDien> list = conn.Query<DeThiTrinhDien>("SP_TrangChu_DeThi_Filter", parameters, commandType: CommandType.StoredProcedure);
                    return list;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
        public async Task<DeThiTrinhDien> GetByID(int deThiID)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@DeThiID", deThiID);
                    DeThiTrinhDien list = conn.QueryFirstOrDefault<DeThiTrinhDien>("SP_QLTTNTT_DeThi_GetByID", parameters, commandType: CommandType.StoredProcedure);
                    return list;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        public async Task<int> DongDeThi(int deThiID)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@DeThiID", deThiID);
                    int item = conn.QueryFirstOrDefault<int>("SP_QLTTNTT_DeThi_Dong", parameters, commandType: CommandType.StoredProcedure);
                    return item;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
        #region DeThi_CauHoi
        public async Task<DeThi_CauHoi> DeThi_CauHoi_Add(DeThi_CauHoi data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@DeThiID", data.DeThiID);
                    parameters.Add("@CauHoiID", data.CauHoiID);
                    DeThi_CauHoi item = conn.QueryFirstOrDefault<DeThi_CauHoi>("SP_QLTTNTT_DeThi_CauHoi_Add", parameters, commandType: CommandType.StoredProcedure);
                    return item;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }

            }
        }
        public async Task<IEnumerable<DeThi_CauHoi_TrinhDien>> DeThi_CauHoi_GetByID(int deThiID)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@DeThiID", deThiID);
                    IEnumerable<DeThi_CauHoi_TrinhDien> list = conn.Query<DeThi_CauHoi_TrinhDien>("SP_QLTTNTT_DeThi_CauHoi_GetByID", parameters, commandType: CommandType.StoredProcedure);
                    return list;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
        public async Task<int> DeThi_CauHoi_Delete(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@DeThiID", id);
                    int item = conn.QueryFirstOrDefault<int>("SP_TrangChu_DeThi_CauHoi_Delete", parameters, commandType: CommandType.StoredProcedure);
                    return item;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }
        #endregion
        #region DeThi_SinhVien
        public async Task<DeThi_SinhVien> DeThi_SinhVien_Add(DeThi_SinhVien data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@DeThiID", data.DeThiID);
                    parameters.Add("@MaSinhVien", data.MaSinhVien);
                    DeThi_SinhVien item = conn.QueryFirstOrDefault<DeThi_SinhVien>("SP_TrangChu_DeThi_SinhVien_Add", parameters, commandType: CommandType.StoredProcedure);
                    return item;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }

            }
        }
        public async Task<IEnumerable<DeThi_SinhVien>> DeThi_SinhVien_GetByID(int deThiID)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@DeThiID", deThiID);
                    IEnumerable<DeThi_SinhVien> list = conn.Query<DeThi_SinhVien>("SP_TrangChu_DeThi_SinhVien_GetByID", parameters, commandType: CommandType.StoredProcedure);
                    return list;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
        public async Task<int> DeThi_SinhVien_Delete(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@DeThiID", id);
                    int item = conn.QueryFirstOrDefault<int>("SP_TrangChu_DeThi_SinhVien_Delete", parameters, commandType: CommandType.StoredProcedure);
                    return item;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }
        #endregion

        #region ThongBao
        public async Task<ThongBao> ThongBao(ThongBao data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@DeThiID", data.DeThiID);
                    parameters.Add("@MaSinhVien", data.MaSinhVien);
                    parameters.Add("@NoiDung", data.NoiDung);
                    ThongBao item = conn.QueryFirstOrDefault<ThongBao>("SP_TrangChu_DeThi_ThongBao", parameters, commandType: CommandType.StoredProcedure);
                    return item;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }

            }
        }
        #endregion

        #region PhongThi
        public async Task<IEnumerable<DeThiTrinhDien>> GetByMSV(string msv)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@MaSinhVien", msv);
                    IEnumerable<DeThiTrinhDien> list = conn.Query<DeThiTrinhDien>("SP_TrangChu_DeThi_GetByMSV", parameters, commandType: CommandType.StoredProcedure);
                    return list;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        public async Task<int> CheckMaVaoThi(string ma, int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@MaVaoThi", ma);
                    parameters.Add("@DeThiID", id);
                    int item = conn.QueryFirstOrDefault<int>("SP_TrangChu_DeThi_CheckMaVaoThi", parameters, commandType: CommandType.StoredProcedure);
                    return item;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
        #endregion
    }
}