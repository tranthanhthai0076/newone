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
    internal class CthdDAL : DBConnection
    {
        public List<CthdBEL> ReadHoaDon()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HoaDon ", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            List<CthdBEL> lstCus = new List<CthdBEL>();

            while (reader.Read())
            {
                CthdBEL cus = new CthdBEL();
                cus.id = int.Parse(reader["ID"].ToString());
                cus.mahd = int.Parse(reader["MaHoaDon"].ToString());
                cus.masp = int.Parse(reader["MaSanPham"].ToString());
                cus.sl = int.Parse(reader["SoLuongMua"].ToString());
                cus.dg = int.Parse(reader["DonGia"].ToString());
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
        //public int AddHoaDon(CthdBEL cus)
        //{
        //    int insertedHoaDonId = -1; // Giá trị mặc định nếu không thành công

        //    using (SqlConnection conn = CreateConnection())
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("INSERT INTO HoaDon VALUES (@MaKhachHang, @MaNhanVien, @NgayMua, @TongTienHoaDon); SELECT SCOPE_IDENTITY();", conn);

        //        cmd.Parameters.AddWithValue("@MaKhachHang", cus.Makh);
        //        cmd.Parameters.AddWithValue("@MaNhanVien", cus.Manv);
        //        cmd.Parameters.AddWithValue("@NgayMua", cus.ngaymua);
        //        cmd.Parameters.AddWithValue("@TongTienHoaDon", cus.tongtien);

        //        insertedHoaDonId = Convert.ToInt32(cmd.ExecuteScalar());
        //    }
        //    return insertedHoaDonId;
        //}

        //public List<KhachHangBEL> ReadKhachHang1(KhachHangBEL cus1)
        //{
        //    SqlConnection conn = CreateConnection();
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("select * from KhachHang where makhachhang=@makhachhang ", conn);

        //    cmd.Parameters.Add(new SqlParameter("@makhachhang", cus1.Ma));
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    List<KhachHangBEL> lstCus = new List<KhachHangBEL>();

        //    while (reader.Read())
        //    {
        //        KhachHangBEL cus = new KhachHangBEL();
        //        cus.Ten = reader["TenKhachHang"].ToString();
        //        cus.Dc = reader["DiaChi"].ToString();
        //        cus.Sdt = reader["SoDienThoai"].ToString();
        //        cus.Email = reader["EMAIL"].ToString();
        //        lstCus.Add(cus);
        //    }
        //    conn.Close();
        //    return lstCus;
        //}

    }
}
