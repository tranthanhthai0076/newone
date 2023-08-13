using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHST.DALL
{
    internal class KhachHangDAL : DBConnection
    {
        public List<KhachHangBEL> ReadKhachHang()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from KhachHang ", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            List<KhachHangBEL> lstCus = new List<KhachHangBEL>();

            while (reader.Read())
            {
                KhachHangBEL cus = new KhachHangBEL();
                cus.Ma = int.Parse(reader["MaKhachHang"].ToString());
                cus.Ten = reader["TenKhachHang"].ToString();
                cus.Dc = reader["DiaChi"].ToString();
                cus.Sdt = reader["SoDienThoai"].ToString();
                cus.Email = reader["EMAIL"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }

        public List<KhachHangBEL> ReadKhachHang1(KhachHangBEL cus1)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from KhachHang where makhachhang=@makhachhang ", conn);
     
            cmd.Parameters.Add(new SqlParameter("@makhachhang", cus1.Ma));
            SqlDataReader reader = cmd.ExecuteReader();
            List<KhachHangBEL> lstCus = new List<KhachHangBEL>();

            while (reader.Read())
            {
                KhachHangBEL cus = new KhachHangBEL();
                cus.Ten = reader["TenKhachHang"].ToString();
                cus.Dc = reader["DiaChi"].ToString();
                cus.Sdt = reader["SoDienThoai"].ToString();
                cus.Email = reader["EMAIL"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }

    }
}
