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
    public class SinhVienRepository : ConnectDatabase, ISinhVienRepository
    {
        public async Task<IEnumerable<SinhVien>> Gets()
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    IEnumerable<SinhVien> list = conn.Query<SinhVien>("SP_TrangChu_SinhVien_Gets", commandType: CommandType.StoredProcedure);
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
        public async Task<SinhVien> Add(SinhVien data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@MaSinhVien", data.MaSinhVien);
                    parameters.Add("@HoTen", data.HoTen);
                    parameters.Add("@GioiTinh", data.GioiTinh);
                    parameters.Add("@NgaySinh", data.NgaySinh);
                    parameters.Add("@DiaChi", data.DiaChi);
                    parameters.Add("@HinhAnh", data.HinhAnh);
                    parameters.Add("@TrangThai", data.TrangThai);
                    SinhVien item = conn.QueryFirstOrDefault<SinhVien>("SP_TrangChu_SinhVien_Add", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<SinhVien> Edit(SinhVien data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@SinhVienID", data.SinhVienID);
                    parameters.Add("@MaSinhVien", data.MaSinhVien);
                    parameters.Add("@HoTen", data.HoTen);
                    parameters.Add("@GioiTinh", data.GioiTinh);
                    parameters.Add("@NgaySinh", data.NgaySinh);
                    parameters.Add("@DiaChi", data.DiaChi);
                    parameters.Add("@HinhAnh", data.HinhAnh);
                    parameters.Add("@TrangThai", data.TrangThai);
                    SinhVien item = conn.QueryFirstOrDefault<SinhVien>("SP_TrangChu_SinhVien_Edit", parameters, commandType: CommandType.StoredProcedure);
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
                    parameters.Add("@SinhVienID", id);
                    int item = conn.QueryFirstOrDefault<int>("SP_TrangChu_SinhVien_Delete", parameters, commandType: CommandType.StoredProcedure);
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
                    int item = conn.QueryFirstOrDefault<int>("SP_TrangChu_SinhVien_Deletes", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<int> Check(SinhVienCheck data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@SinhVienID", data.SinhVienID);
                    parameters.Add("@MaSinhVien", data.MaSinhVien);
                    int item = conn.QueryFirstOrDefault<int>("SP_TrangChu_SinhVien_Check", parameters, commandType: CommandType.StoredProcedure);
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
        public async Task<SinhVien> GetByID(string id)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@MaSinhVien", id);
                    SinhVien item = conn.QueryFirstOrDefault<SinhVien>("SP_TrangChu_SinhVien_GetByID", parameters, commandType: CommandType.StoredProcedure);
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