using QLTTNTT.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QLTTNTT.Repository
{
    public class ConnectDatabase : IConnectDatabase
    {
        public SqlConnection IConnectData()
        {
            try
            {
                var conn = new SqlConnection
                {
                    ConnectionString = @"Data Source=DESKTOP-CDO0SQ2\SQLEXPRESS;Initial Catalog=QLTTN;User ID=sa; Password=123"
                };
                return conn;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}