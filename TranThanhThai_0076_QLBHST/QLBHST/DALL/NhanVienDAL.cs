using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHST.DALL
{
    internal class NhanVienDAL : DBConnection
    {
        public List<NhanVienBEL> ReadNV()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from NhanVien ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<NhanVienBEL> lstCus = new List<NhanVienBEL>();

            while (reader.Read())
            {
                NhanVienBEL cus = new NhanVienBEL();
                cus.Ma = int.Parse(reader["MaNhanVien"].ToString());
                cus.Ten = reader["TenNhanVien"].ToString();
                cus.Chucvu = reader["ChucVu"].ToString();
                cus.Dc = reader["DiaChi"].ToString();
                cus.Sdt = reader["SoDienThoai"].ToString();
                cus.Email = reader["EMAIL"].ToString();
                cus.Luong = int.Parse(reader["Luong"].ToString());
                cus.ngaybd = DateTime.Parse(reader["NgayBatDauLam"].ToString());
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }

        public List<NhanVienBEL> ReadNV1(NhanVienBEL cus1)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from NhanVien where MaNhanVien=@MaNhanVien ", conn);
    

            cmd.Parameters.Add(new SqlParameter("@MaNhanVien", cus1.Ma));
            SqlDataReader reader = cmd.ExecuteReader();
            List<NhanVienBEL> lstCus = new List<NhanVienBEL>();

            while (reader.Read())
            {
                NhanVienBEL cus = new NhanVienBEL();
                cus.Ma = int.Parse(reader["MaNhanVien"].ToString());
                cus.Ten = reader["TenNhanVien"].ToString();
                cus.Chucvu = reader["ChucVu"].ToString();
                cus.Dc = reader["DiaChi"].ToString();
                cus.Sdt = reader["SoDienThoai"].ToString();
                cus.Email = reader["EMAIL"].ToString();
                cus.Luong = int.Parse(reader["Luong"].ToString());
                cus.ngaybd = DateTime.Parse(reader["NgayBatDauLam"].ToString());
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }

    }
}
