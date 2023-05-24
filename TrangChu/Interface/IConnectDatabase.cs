using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TrangChu.Interface
{
    public interface IConnectDatabase
    {
        SqlConnection IConnectData();
    }
}