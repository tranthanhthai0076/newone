using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHST.DALL
{
    public class DBConnection
    {
        public DBConnection()
        {
        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source= MSI\SQLEXPRESS ;Initial Catalog= QLBHSIEUTHI; User Id=sa; Password=11";
            return conn;
        }
    }
}