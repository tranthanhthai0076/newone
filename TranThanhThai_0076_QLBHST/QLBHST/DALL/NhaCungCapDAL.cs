using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHST.DALL
{
    internal class NhaCungCapDAL : DBConnection
    {
        public List<NhaCungCapBEL> ReadNhaCungCap()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from NhaCungCap ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<NhaCungCapBEL> lstCus = new List<NhaCungCapBEL>();

            while (reader.Read())
            {
                NhaCungCapBEL cus = new NhaCungCapBEL();
                cus.Ma = int.Parse(reader["manhacungcap"].ToString());
                cus.Ten = reader["TenNhaCungCap"].ToString();
                cus.Diachi = reader["DiaChi"].ToString();
                cus.sdt = reader["SoDienThoai"].ToString();
                cus.Email = reader["EMAIL"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void EditNhaCungCap(NhaCungCapBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update NhaCungCap set TenNhaCungCap=@TenNhaCungCap ,DiaChi=@DiaChi,SoDienThoai=@SoDienThoai,Email=@Email where manhacungcap=@manhacungcap ", conn);
            cmd.Parameters.Add(new SqlParameter("@manhacungcap", cus.Ma));
            cmd.Parameters.Add(new SqlParameter("@TenNhaCungCap", cus.Ten));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", cus.Diachi));
            cmd.Parameters.Add(new SqlParameter("@SoDienThoai", cus.sdt));
            cmd.Parameters.Add(new SqlParameter("@Email", cus.Email));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteNhaCungCap(NhaCungCapBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from NhaCungCap where manhacungcap=@manhacungcap", conn);
            cmd.Parameters.Add(new SqlParameter("@manhacungcap", cus.Ma));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void AddNhaCungCap(NhaCungCapBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into NhaCungCap values(@TenNhaCungCap,@DiaChi,@SoDienThoai,@Email)", conn);

            cmd.Parameters.Add(new SqlParameter("@TenNhaCungCap", cus.Ten));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", cus.Diachi));
            cmd.Parameters.Add(new SqlParameter("@SoDienThoai", cus.sdt));
            cmd.Parameters.Add(new SqlParameter("@Email", cus.Email));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
