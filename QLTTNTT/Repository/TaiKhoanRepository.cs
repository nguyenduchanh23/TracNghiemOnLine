using Dapper;
using QLTTNTT.Interface;
using QLTTNTT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace QLTTNTT.Repository
{
    public class TaiKhoanRepository : ConnectDatabase, ITaiKhoanRepository
    {
        public async Task<IEnumerable<TaiKhoan>> Gets()
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    IEnumerable<TaiKhoan> list = conn.Query<TaiKhoan>("SP_QLTTNTT_TaiKhoan_Gets", commandType: CommandType.StoredProcedure);
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


        /// <summary>
        /// Tự động khi thêm sinh viên
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<TaiKhoan> Add(TaiKhoan data)
        {
            string pass_Md5 = Hash(data.Password);
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Username", data.Username);
                    parameters.Add("@Password", pass_Md5);
                    parameters.Add("@Quyen", data.Quyen);
                    parameters.Add("@TrangThai", data.TrangThai);
                    parameters.Add("@Password_Random", data.Password_Random);
                    TaiKhoan item = conn.QueryFirstOrDefault<TaiKhoan>("SP_QLTTNTT_TaiKhoan_Add", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<TaiKhoan> DoiTrangThai(TaiKhoan data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@TaiKhoanID", data.TaiKhoanID);
                    parameters.Add("@Username", data.Username);
                    parameters.Add("@TrangThai", data.TrangThai);
                    TaiKhoan item = conn.QueryFirstOrDefault<TaiKhoan>("SP_QLTTNTT_TaiKhoan_DoiTrangThai", parameters, commandType: CommandType.StoredProcedure);
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
                    parameters.Add("@TaiKhoanID", id);
                    int item = conn.QueryFirstOrDefault<int>("SP_QLTTNTT_TaiKhoan_Delete", parameters, commandType: CommandType.StoredProcedure);
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
                    int item = conn.QueryFirstOrDefault<int>("SP_QLTTNTT_TaiKhoan_Deletes", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<int> Check(TaiKhoanCheck data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Username", data.Username);
                    int item = conn.QueryFirstOrDefault<int>("SP_QLTTNTT_TaiKhoan_Check", parameters, commandType: CommandType.StoredProcedure);
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
        /// <summary> Add_Excel
        /// Thêm từ quản lý sinh viên
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<TaiKhoan> Add_Excel(TaiKhoan data)
        {
            string pass_Md5 = Hash(data.Password);
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Username", data.Username);
                    parameters.Add("@Password", pass_Md5);
                    parameters.Add("@Quyen", data.Quyen);
                    parameters.Add("@TrangThai", data.TrangThai);
                    parameters.Add("@Password_Random", data.Password_Random);
                    TaiKhoan item = conn.QueryFirstOrDefault<TaiKhoan>("SP_QLTTNTT_TaiKhoan_Add2", parameters, commandType: CommandType.StoredProcedure);
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
        public async Task<TaiKhoan> DoiMatKhau(TaiKhoan data)
        {
            string pass_Md5 = Hash(data.Password);
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Username", data.Username);
                    parameters.Add("@Password", pass_Md5);
                    parameters.Add("@Password_Random", data.Password_Random);
                    TaiKhoan item = conn.QueryFirstOrDefault<TaiKhoan>("SP_QLTTNTT_TaiKhoan_DoiMatKhau", parameters, commandType: CommandType.StoredProcedure);
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
        public static string Hash(string text)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            return hashSb.ToString();
        }

        public async Task<TaiKhoan> Authorize(TaiKhoan data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@TaiKhoan", data.Username);
                    parameters.Add("@MatKhau", Hash(data.Password));
                    TaiKhoan item = conn.QueryFirstOrDefault<TaiKhoan>("SP_QLTTNTT_TaiKhoan_Admin_Login", parameters, commandType: CommandType.StoredProcedure);
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