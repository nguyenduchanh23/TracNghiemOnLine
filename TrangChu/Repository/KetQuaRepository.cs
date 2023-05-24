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
    public class KetQuaRepository : ConnectDatabase, IKetQuaRepository
    {
        private readonly SqlConnection _conn;
        public KetQuaRepository()
        {
            _conn = IConnectData();
        }

        
        public async Task<KetQua> Add(KetQua data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@DeThiID", data.DeThiID);
                    parameters.Add("@MaSinhVien", data.MaSinhVien);
                    parameters.Add("@Diem", data.Diem);
                    parameters.Add("@ThoiGianLamBai", data.ThoiGianLamBai);
                    parameters.Add("@SoCauHoiDung", data.SoCauHoiDung);
                    KetQua item = conn.QueryFirstOrDefault<KetQua>("SP_QLTTNTT_KetQua_Add", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<IEnumerable<KetQuaTrinhDien>> Get(KetQuaTrinhDien data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@MaSinhVien", data.MaSinhVien);
                    parameters.Add("@DeThiID", data.DeThiID);
                    IEnumerable<KetQuaTrinhDien> item = conn.Query<KetQuaTrinhDien>("SP_QLTTNTT_KetQua_Get", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<IEnumerable<KetQuaTrinhDien>> GetByMaSV(string maSV)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@MaSinhVien", maSV);
                    IEnumerable<KetQuaTrinhDien> item = conn.Query<KetQuaTrinhDien>("SP_QLTTNTT_KetQua_GetByMaSV", parameters, commandType: CommandType.StoredProcedure);
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