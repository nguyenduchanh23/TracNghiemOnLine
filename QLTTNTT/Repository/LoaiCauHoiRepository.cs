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
    public class LoaiCauHoiRepository : ConnectDatabase , ILoaiCauHoiRepository
    {
        public async Task<IEnumerable<LoaiCauHoi>> Gets()
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    IEnumerable<LoaiCauHoi> list = conn.Query<LoaiCauHoi>("SP_QLTTNTT_LoaiCauHoi_Gets", commandType: CommandType.StoredProcedure);
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
        public async Task<LoaiCauHoi> Add(LoaiCauHoi data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@TenLoai", data.TenLoai);
                    parameters.Add("@MoTa", data.MoTa);
                    LoaiCauHoi item = conn.QueryFirstOrDefault<LoaiCauHoi>("SP_QLTTNTT_LoaiCauHoi_Add", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<LoaiCauHoi> Edit(LoaiCauHoi data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@LoaiID", data.LoaiID);
                    parameters.Add("@TenLoai", data.TenLoai);
                    parameters.Add("@MoTa", data.MoTa);
                    LoaiCauHoi item = conn.QueryFirstOrDefault<LoaiCauHoi>("SP_QLTTNTT_LoaiCauHoi_Edit", parameters, commandType: CommandType.StoredProcedure);
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
                    parameters.Add("@LoaiID", id);
                    int item = conn.QueryFirstOrDefault<int>("SP_QLTTNTT_LoaiCauHoi_Delete", parameters, commandType: CommandType.StoredProcedure);
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
                    int item = conn.QueryFirstOrDefault<int>("SP_QLTTNTT_LoaiCauHoi_Deletes", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<int> Check(LoaiCauHoiCheck data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@LoaiID", data.LoaiID);
                    parameters.Add("@TenLoai", data.TenLoai);
                    int item = conn.QueryFirstOrDefault<int>("SP_QLTTNTT_LoaiCauHoi_Check", parameters, commandType: CommandType.StoredProcedure);
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
    }
}