using Dapper;
using TrangChu.Interface;
using TrangChu.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TrangChu.Repository
{
    public class TaiKhoanRepository : ConnectDatabase, ITaiKhoanRepository
    {
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
                    TaiKhoan item = conn.QueryFirstOrDefault<TaiKhoan>("SP_TrangChu_TaiKhoan_DoiMatKhau", parameters, commandType: CommandType.StoredProcedure);
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
        public async Task<TaiKhoan> CheckLogin(TaiKhoan data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@TaiKhoan", data.Username);
                    parameters.Add("@MatKhau", Hash(data.Password));
                    TaiKhoan item = conn.QueryFirstOrDefault<TaiKhoan>("SP_TrangChu_TaiKhoan_Login", parameters, commandType: CommandType.StoredProcedure);
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