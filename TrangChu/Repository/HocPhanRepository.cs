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
    public class HocPhanRepository : ConnectDatabase, IHocPhanRepository
    {
        private readonly SqlConnection _conn;
        public HocPhanRepository()
        {
            _conn = IConnectData();
        }
        public async Task<IEnumerable<HocPhan>> Gets(Search data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@TuKhoa", data.TuKhoa);
                    IEnumerable<HocPhan> list = conn.Query<HocPhan>("SP_TrangChu_HocPhan_Gets", parameters, commandType: CommandType.StoredProcedure);
                    return list;
                }
                catch(Exception ex)
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
        public async Task<HocPhan> Add(HocPhan data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@TenHocPhan", data.TenHocPhan);
                    parameters.Add("@MaHocPhan", data.MaHocPhan);
                    parameters.Add("@MoTa", data.MoTa);
                    HocPhan item = conn.QueryFirstOrDefault<HocPhan>("SP_TrangChu_HocPhan_Add", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<HocPhan> Edit(HocPhan data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@HocPhanID", data.HocPhanID);
                    parameters.Add("@TenHocPhan", data.TenHocPhan);
                    parameters.Add("@MaHocPhan", data.MaHocPhan);
                    parameters.Add("@MoTa", data.MoTa);
                    HocPhan item = conn.QueryFirstOrDefault<HocPhan>("SP_TrangChu_HocPhan_Edit", parameters, commandType: CommandType.StoredProcedure);
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
                    parameters.Add("@HocPhanID", id);
                    int item = conn.QueryFirstOrDefault<int>("SP_TrangChu_HocPhan_Delete", parameters, commandType: CommandType.StoredProcedure);
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
                    int item = conn.QueryFirstOrDefault<int>("SP_TrangChu_HocPhan_Deletes", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<int> Check(HocPhanCheck data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@HocPhanID", data.HocPhanID);
                    parameters.Add("@MaHocPhan", data.MaHocPhan);
                    int item = conn.QueryFirstOrDefault<int>("SP_TrangChu_HocPhan_Check", parameters, commandType: CommandType.StoredProcedure);
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