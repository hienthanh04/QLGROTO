using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGROTO.DAO
{
    internal class QUYDINHDAO
    {
        DataConnection dc;

        private static QUYDINHDAO instance;  
        private QUYDINHDAO()
        {
            dc = new DataConnection();
        }
        public static QUYDINHDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new QUYDINHDAO();
                return instance;
            }
            set { instance = value; }
        }
        public bool CapNhatTiLeLai(double f)
        {
            SqlConnection con = dc.getConnect();
            string sql = "UPDATE QUYDINH SET TiLeLai = @ff";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ff", f);

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public int HienThiSoXe()
        {
            SqlConnection con = dc.getConnect();
            string sql = "SELECT SoXeSuaChuaToiDa FROM QUYDINH";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            var result = cmd.ExecuteScalar();
            int n = Convert.ToInt32(result);
            con.Close();
            return n;

        }
        public int HienThiSoHieuXe()
        {
            SqlConnection con = dc.getConnect();
            string sql = "SELECT SoLuongHieuXe FROM QUYDINH";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            var result = cmd.ExecuteScalar();
            int n = Convert.ToInt32(result);
            con.Close();
            return n;
        }

        public int HienThiSoLoaiTienCong()
        {
            SqlConnection con = dc.getConnect();
            string sql = "SELECT SoLoaiTienCong FROM QUYDINH";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            var result = cmd.ExecuteScalar();
            int n = Convert.ToInt32(result);
            con.Close();
            return n;
        }

        public int HienThiSoLoaiVTPT()
        {
            SqlConnection con = dc.getConnect();
            string sql = "SELECT SoLoaiVTPT FROM QUYDINH";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            var result = cmd.ExecuteScalar();
            int n = Convert.ToInt32(result);
            con.Close();
            return n;
        }

        public double LoadTiLeLai()
        {
            SqlConnection con = dc.getConnect();
            string sql = "SELECT TiLeLai FROM QUYDINH";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            var result = cmd.ExecuteScalar();
            double n = Convert.ToDouble(result);
            con.Close();
            return n;
        }
        public decimal HienThiTiLeLai()
        {
            SqlConnection con = dc.getConnect();
            string sql = "SELECT TiLeLai FROM QUYDINH";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            var result = cmd.ExecuteScalar();
            decimal n = Convert.ToDecimal(result);
            con.Close();
            return n;

        }
        public bool CapNhatSoXeMax(int n)
        {
            SqlConnection con = dc.getConnect();
            string sql = "UPDATE QUYDINH SET SoXeSuaChuaToiDa = @nn";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nn", n);
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool CapNhatTatCaQuyDinh(int soXe, int soHieuXe, int soTienCong, int soVTPT)
        {
            SqlConnection con = dc.getConnect();
            string sql = "UPDATE QUYDINH SET SoXeSuaChuaToiDa = @soXe, SoLuongHieuXe = @hx, SoLoaiTienCong = @tc, SoLoaiVTPT = @vt";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@soXe", soXe);
                cmd.Parameters.AddWithValue("@hx", soHieuXe);
                cmd.Parameters.AddWithValue("@tc", soTienCong);
                cmd.Parameters.AddWithValue("@vt", soVTPT);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
