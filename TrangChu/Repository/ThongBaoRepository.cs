using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TrangChu.Interface;
using TrangChu.Models;

namespace TrangChu.Repository
{
    public class ThongBaoRepository : ConnectDatabase, IThongBaoRepository
    {
    
        public async Task<IEnumerable<ThongBao>> GetsByMaSV(string maSV)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@MaSinhVien", maSV);
                    IEnumerable<ThongBao> list = conn.Query<ThongBao>("SP_TrangChu_ThongBao_GetByMaSV", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<int> Deletes(string listID)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@ListID", listID);
                    int item = conn.QueryFirstOrDefault<int>("SP_TrangChu_ThongBao_Deletes", parameters, commandType: CommandType.StoredProcedure);
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