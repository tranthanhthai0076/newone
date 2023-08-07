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
        //public void EditNhaCungCap(NhaCungCapBEL cus)
        //{
        //    SqlConnection conn = CreateConnection();
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("update TAIKHOAN set MatKhau=@Matkhau where TenTaiKhoan=@TenTaiKhoan and Email=@Email", conn);
        //    cmd.Parameters.Add(new SqlParameter("@TenTaiKhoan", cus.Tentk));
        //    cmd.Parameters.Add(new SqlParameter("@Matkhau", cus.Matkhau));
        //    cmd.Parameters.Add(new SqlParameter("@Email", cus.Email));

        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}
        //public void DeleteNhaCungCap(NhaCungCapBEL cus)
        //{
        //    SqlConnection conn = CreateConnection();
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("delete from CUSTOMER where id=@id", conn);
        //    cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}
        //public void NewNhaCungCap(NhaCungCapBEL cus)
        //{
        //    SqlConnection conn = CreateConnection();
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("insert into TAIKHOAN values(@id,@TenTaiKhoan,@Matkhau,@Email)", conn);
        //    cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
        //    cmd.Parameters.Add(new SqlParameter("@TenTaiKhoan", cus.Tentk));
        //    cmd.Parameters.Add(new SqlParameter("@Matkhau", cus.Matkhau));
        //    cmd.Parameters.Add(new SqlParameter("@Email", cus.Email));
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}
    }
}
