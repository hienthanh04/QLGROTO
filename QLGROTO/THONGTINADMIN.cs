using QLGROTO.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGROTO
{
    public partial class THONGTINADMIN : Form
    {
        public string tendangnhap { get; set; }

        public THONGTINADMIN()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            SqlDataReader dr = NHANVIENDAO.Instance.HienThiThongTin(tendangnhap);
            if (dr.Read())
            {
                tentxtbox.Text = dr["TenNV"].ToString();
                dctxtbox.Text = dr["DiaChi"].ToString();
                dthtxtbox.Text = dr["DienThoai"].ToString();
                emailtxtbox.Text = dr["Email"].ToString();
                chucvutxtbox.Text = dr["ChucVu"].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SUATHONGTINADMIN s = new SUATHONGTINADMIN();
            s.tendangnhap = tendangnhap;
            s.ten = tentxtbox.Text;
            s.diachi = dctxtbox.Text;
            s.dth = dthtxtbox.Text;
            s.email = emailtxtbox.Text;
            s.chucvu = chucvutxtbox.Text;

            s.ShowDialog();
            HienThi();
        }

        private void THONGTINADMIN_Load(object sender, EventArgs e)
        {

            tdntxtbox.Text = tendangnhap;
            SqlDataReader dr = NHANVIENDAO.Instance.HienThiThongTin(tendangnhap);
            if (dr.Read())
            {
                tentxtbox.Text = dr["TenNV"].ToString();
                dctxtbox.Text = dr["DiaChi"].ToString();
                dthtxtbox.Text = dr["DienThoai"].ToString();
                emailtxtbox.Text = dr["Email"].ToString();
                chucvutxtbox.Text = dr["ChucVu"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DOIMATKHAU d = new DOIMATKHAU();
            d.tendangnhap = tendangnhap;

            d.ShowDialog();
        }

        private void thoatbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
