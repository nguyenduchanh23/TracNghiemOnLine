using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QLTTNTT.Interface
{
    public interface IConnectDatabase
    {
        SqlConnection IConnectData();
    }
}