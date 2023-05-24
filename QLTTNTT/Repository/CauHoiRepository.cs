using Dapper;
using QLTTNTT.Interface;
using QLTTNTT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace QLTTNTT.Repository
{
    public class CauHoiRepository : ConnectDatabase ,ICauHoiRepository
    {
        private readonly SqlConnection _conn;
        public CauHoiRepository()
        {
            _conn = IConnectData();
        }

        public async Task<IEnumerable<CauHoiTrinhDien>> Gets()
        {
            using ( SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    IEnumerable<CauHoiTrinhDien> list = conn.Query<CauHoiTrinhDien>("SP_QLTTNTT_CauHoi_Gets", commandType: CommandType.StoredProcedure);
                    return list;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            
        }
        public async Task<CauHoi> Add(CauHoi data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@NoiDung", data.NoiDung);
                    parameters.Add("@HocPhanID", data.HocPhanID);
                    parameters.Add("@MucDo", data.MucDo);
                    parameters.Add("@LoaiID", data.LoaiID);
                    CauHoi item = conn.QueryFirstOrDefault<CauHoi>("SP_QLTTNTT_CauHoi_Add", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<CauHoi> Edit(CauHoi data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@CauHoiID", data.CauHoiID);
                    parameters.Add("@NoiDung", data.NoiDung);
                    parameters.Add("@HocPhanID", data.HocPhanID);
                    parameters.Add("@MucDo", data.MucDo);
                    parameters.Add("@LoaiID", data.LoaiID);
                    CauHoi item = conn.QueryFirstOrDefault<CauHoi>("SP_QLTTNTT_CauHoi_Edit", parameters, commandType: CommandType.StoredProcedure);
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
        public async Task<int> Delete(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@CauHoiID", id);
                    int item = conn.QueryFirstOrDefault<int>("SP_QLTTNTT_CauHoi_Delete", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<int> Deletes(string listID)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@ListID", listID);
                    int item = conn.QueryFirstOrDefault<int>("SP_QLTTNTT_CauHoi_Deletes", parameters, commandType: CommandType.StoredProcedure);
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
        public async Task<IEnumerable<CauHoiTrinhDien>> Filter(Filter data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@HocPhanID", data.HocPhanID);
                    parameters.Add("@LoaiID", data.LoaiID);
                    parameters.Add("@MucDo", data.MucDo);
                    IEnumerable<CauHoiTrinhDien> list = conn.Query<CauHoiTrinhDien>("SP_QLTTNTT_CauHoi_Filter", parameters, commandType: CommandType.StoredProcedure);
                    return list;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        public async Task<IEnumerable<CauHoi>> GetsByHocPhanID(CauHoi data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@HocPhanID", data.HocPhanID);
                    parameters.Add("@MucDo", data.MucDo);
                    IEnumerable<CauHoi> list = conn.Query<CauHoi>("SP_QLTTNTT_CauHoi_GetsByHocPhanID", parameters, commandType: CommandType.StoredProcedure);
                    return list;
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

    }
}