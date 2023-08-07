using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHST.DALL
{
    internal class TaiKhoanDAL : DBConnection
    {
        public List<TaiKhoanBEL> ReadTaiKhoan()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from TAIKHOAN ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<TaiKhoanBEL> lstCus = new List<TaiKhoanBEL>();

            while (reader.Read())
            {
                TaiKhoanBEL cus = new TaiKhoanBEL();
                cus.Id = int.Parse(reader["id"].ToString());
                cus.Tentk = reader["TENTAIKHOAN"].ToString();
                cus.Matkhau = reader["MATKHAU"].ToString();
                cus.Email = reader["EMAIL"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void EditTaikhoan(TaiKhoanBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update TAIKHOAN set MatKhau=@Matkhau where TenTaiKhoan=@TenTaiKhoan and Email=@Email", conn);
            cmd.Parameters.Add(new SqlParameter("@TenTaiKhoan", cus.Tentk));
            cmd.Parameters.Add(new SqlParameter("@Matkhau", cus.Matkhau));
            cmd.Parameters.Add(new SqlParameter("@Email", cus.Email));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from CUSTOMER where id=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewTaiKhoan(TaiKhoanBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into TAIKHOAN values(@TenTaiKhoan,@Matkhau,@Email)", conn);
            cmd.Parameters.Add(new SqlParameter("@TenTaiKhoan", cus.Tentk));
            cmd.Parameters.Add(new SqlParameter("@Matkhau", cus.Matkhau));
            cmd.Parameters.Add(new SqlParameter("@Email", cus.Email));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
