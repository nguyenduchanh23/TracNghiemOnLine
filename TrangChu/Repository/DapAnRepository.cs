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
    public class DapAnRepository : ConnectDatabase, IDapAnRepository
    {
        public async Task<DapAn> Add(DapAn data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@CauHoiID", data.CauHoiID);
                    parameters.Add("@CauTraLoi", data.CauTraLoi);
                    parameters.Add("@DapAnDung", data.DapAnDung);
                    DapAn item = conn.QueryFirstOrDefault<DapAn>("SP_TrangChu_DapAn_Add", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<DapAn> Edit(DapAn data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@DapAnID", data.DapAnID);
                    parameters.Add("@CauHoiID", data.CauHoiID);
                    parameters.Add("@CauTraLoi", data.CauTraLoi);
                    parameters.Add("@DapAnDung", data.DapAnDung);
                    DapAn item = conn.QueryFirstOrDefault<DapAn>("SP_TrangChu_DapAn_Edit", parameters, commandType: CommandType.StoredProcedure);
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
        public async Task<IEnumerable<DapAn>> GetByID_Dung(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@CauHoiID", id);
                    IEnumerable<DapAn> list = conn.Query<DapAn>("SP_TrangChu_DapAn_GetByCauHoiID_Dung", parameters, commandType: CommandType.StoredProcedure);
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
        public async Task<IEnumerable<DapAn>> GetByID_Sai(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@CauHoiID", id);
                    IEnumerable<DapAn> list = conn.Query<DapAn>("SP_TrangChu_DapAn_GetByCauHoiID_Sai", parameters, commandType: CommandType.StoredProcedure);
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
        public async Task<int> Delete(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@CauHoiID", id);
                    int item = conn.QueryFirstOrDefault<int>("SP_TrangChu_DapAn_Deletes", parameters, commandType: CommandType.StoredProcedure);
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
        public async Task<IEnumerable<DapAn>> GetsByID(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@CauHoiID", id);
                    IEnumerable<DapAn> list = conn.Query<DapAn>("SP_QLTTNTT_DapAn_GetsByCauHoiID", parameters, commandType: CommandType.StoredProcedure);
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