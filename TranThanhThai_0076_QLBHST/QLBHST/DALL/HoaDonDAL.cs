using QLBHST.MODELL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHST.DALL
{
    public class HoaDonDAL : DBConnection
    {
        public List<HoaDonBEL> ReadHoaDon()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HoaDon ", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            List<HoaDonBEL> lstCus = new List<HoaDonBEL>();

            while (reader.Read())
            {
                HoaDonBEL cus = new HoaDonBEL();
                cus.Mahd = int.Parse(reader["MaHoaDon"].ToString());
                cus.Makh = int.Parse(reader["MaKhachHang"].ToString());
                cus.Manv = int.Parse(reader["MaNhanVien"].ToString());
                cus.ngaymua = DateTime.Parse(reader["NgayMua"].ToString());
                cus.tongtien = int.Parse(reader["TongTienHoaDon"].ToString());
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
       
        //public void AddHoaDon(HoaDonBEL cus)
        //{
        //    SqlConnection conn = CreateConnection();
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("insert into HoaDon values(@MaKhachHang,@MaNhanVien,@NgayMua,@TongTienHoaDon)", conn);

        //    cmd.Parameters.Add(new SqlParameter("@MaKhachHang", cus.Makh));
        //    cmd.Parameters.Add(new SqlParameter("@MaNhanVien", cus.Manv));
        //    cmd.Parameters.Add(new SqlParameter("@NgayMua", cus.ngaymua));
        //    cmd.Parameters.Add(new SqlParameter("@TongTienHoaDon", cus.tongtien));
        //    cmd.ExecuteNonQuery();
        //    MessageBox.Show(cus.Mahd.ToString());
        //    conn.Close();

        //}
        public int AddHoaDon(HoaDonBEL cus)
        {
            int insertedHoaDonId = -1; // Giá trị mặc định nếu không thành công

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO HoaDon VALUES (@MaKhachHang, @MaNhanVien, @NgayMua, @TongTienHoaDon); SELECT SCOPE_IDENTITY();", conn);

                cmd.Parameters.AddWithValue("@MaKhachHang", cus.Makh);
                cmd.Parameters.AddWithValue("@MaNhanVien", cus.Manv);
                cmd.Parameters.AddWithValue("@NgayMua", cus.ngaymua);
                cmd.Parameters.AddWithValue("@TongTienHoaDon", cus.tongtien);

                insertedHoaDonId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            return insertedHoaDonId;
        }
        public void EditHoaDon(HoaDonBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update HoaDon set MaKhachHang=@MaKhachHang ,MaNhanVien=@MaNhanVien,TongTienHoaDon=@TongTienHoaDon where MaHoaDon=@MaHoaDon ", conn);
            cmd.Parameters.Add(new SqlParameter("@MaHoaDon", cus.Mahd));
            cmd.Parameters.Add(new SqlParameter("@MaKhachHang", cus.Makh));
            cmd.Parameters.Add(new SqlParameter("@MaNhanVien", cus.Manv));
            cmd.Parameters.Add(new SqlParameter("@TongTienHoaDon", cus.tongtien));

            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}
