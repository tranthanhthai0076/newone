using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    internal class DBConnnection
    {
        public DBConnnection() { }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString=@"Data Source= MSI\SQLEXPRESS ;Initial Catalog= sale; User Id=sa; Password=11";
            return conn;
        }

}
}
