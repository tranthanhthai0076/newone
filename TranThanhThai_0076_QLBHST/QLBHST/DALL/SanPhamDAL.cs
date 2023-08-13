using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHST.DALL
{
    internal class SanPhamDAL : DBConnection
    {
        public List<SanPhamBEL> ReadSanPham()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SanPham ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<SanPhamBEL> lstCus = new List<SanPhamBEL>();

            while (reader.Read())
            {
                SanPhamBEL cus = new SanPhamBEL();
                cus.Ma = int.Parse(reader["MaSanPham"].ToString());
                cus.Ten = reader["TenSanPham"].ToString();
                cus.Gia = int.Parse(reader["GiaBan"].ToString());
                cus.Soluong = int.Parse(reader["SoLuongTonKho"].ToString());
                cus.Ncc = reader["NhaCungCap"].ToString();
                cus.Anh = reader["Anh"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public List<SanPhamBEL> Timkiem(SanPhamBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SanPham where MaSanPham=@MaSanPham or TenSanPham LIKE '%' + @TenSanPham + '%' ", conn);
            cmd.Parameters.Add(new SqlParameter("@TenSanPham", cus.Ten));
            cmd.Parameters.Add(new SqlParameter("@MaSanPham", cus.Ma));
            SqlDataReader reader = cmd.ExecuteReader();

            List<SanPhamBEL> lstCus = new List<SanPhamBEL>();

            while (reader.Read())
            {
                SanPhamBEL cus1 = new SanPhamBEL();
                cus1.Ma = int.Parse(reader["MaSanPham"].ToString());
                cus1.Ten = reader["TenSanPham"].ToString();
                cus1.Gia = int.Parse(reader["GiaBan"].ToString());
                cus1.Soluong = int.Parse(reader["SoLuongTonKho"].ToString());
                cus1.Ncc = reader["NhaCungCap"].ToString();
                cus1.Anh = reader["Anh"].ToString();
                lstCus.Add(cus1);
            }
            conn.Close();
            return lstCus;
        }
        public List<SanPhamBEL> Timkiem1(SanPhamBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SanPham where MaSanPham=@MaSanPham", conn);
            cmd.Parameters.Add(new SqlParameter("@MaSanPham", cus.Ma));
            SqlDataReader reader = cmd.ExecuteReader();

            List<SanPhamBEL> lstCus = new List<SanPhamBEL>();

            while (reader.Read())
            {
                SanPhamBEL cus1 = new SanPhamBEL();
                cus1.Ma = int.Parse(reader["MaSanPham"].ToString());
                cus1.Ten = reader["TenSanPham"].ToString();
                cus1.Gia = int.Parse(reader["GiaBan"].ToString());
                cus1.Soluong = int.Parse(reader["SoLuongTonKho"].ToString());
                cus1.Ncc = reader["NhaCungCap"].ToString();
                cus1.Anh = reader["Anh"].ToString();
                lstCus.Add(cus1);
            }
            conn.Close();
            return lstCus;
        }
        public void EditSanPham(SanPhamBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update SanPham set TenSanPham=@TenSanPham ,GiaBan=@Giaban,SoLuongTonKho=@SoLuongTonKho,NhaCungCap=@NhaCungCap,Anh=@Anh where MaSanPham=@MaSanPham ", conn);
            cmd.Parameters.Add(new SqlParameter("@MaSanPham", cus.Ma));
            cmd.Parameters.Add(new SqlParameter("@TenSanPham", cus.Ten));
            cmd.Parameters.Add(new SqlParameter("@GiaBan", cus.Gia));
            cmd.Parameters.Add(new SqlParameter("@SoLuongTonKho", cus.Soluong));
            cmd.Parameters.Add(new SqlParameter("@NhaCungCap", cus.Ncc));
            cmd.Parameters.Add(new SqlParameter("@Anh", cus.Anh));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteSanPham(SanPhamBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from SanPham where MaSanPham=@MaSanPham", conn);
            cmd.Parameters.Add(new SqlParameter("@MaSanPham", cus.Ma));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void AddSanPham(SanPhamBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into SanPham values(@TenSanPham,@GiaBan,@SoLuongTonKho,@NhaCungCap,@Anh)", conn);

            cmd.Parameters.Add(new SqlParameter("@TenSanPham", cus.Ten));
            cmd.Parameters.Add(new SqlParameter("@GiaBan", cus.Gia));
            cmd.Parameters.Add(new SqlParameter("@SoLuongTonKho", cus.Soluong));
            cmd.Parameters.Add(new SqlParameter("@NhaCungCap", cus.Ncc));
            cmd.Parameters.Add(new SqlParameter("@Anh", cus.Anh));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    

    }
}
