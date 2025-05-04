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
    public partial class TIEPNHANXE : Form
    {
        public TIEPNHANXE()
        {
            InitializeComponent();
            LoadHieuXe();
        }
        public void LoadHieuXe()
        {
            SqlDataReader dr = HIEUXEDAO.Instance.HienThiCBBox();
            while (dr.Read())
            {
                hieuxecbbox.Items.Add(dr["HieuXe"]);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HieuXe_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void BienSo_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void TenChuXe_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

        }


        public bool TiepNhan(string bs, string t, string h, string d, string dth, string email)
        {

            return XEDAO.Instance.TiepNhanXe(bs, t, h, d, dth, email);
        }
        private void huybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hieuxecbbox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private bool IsValidName(string name)
        {
            return !name.Any(char.IsDigit);  
        }

        private bool IsValidPhoneNumber(string phone)
        {
            return phone.All(char.IsDigit);  
        }

        private bool IsValidPhoneNumberLength(string phone)
        {
            return phone.Length == 10;  
        }

        // Kiểm tra tiền nợ không âm
        private bool IsValidDebt(decimal debt)
        {
            return debt >= 0;  // Tiền nợ phải lớn hơn hoặc bằng 0
        }

        // Kiểm tra email hợp lệ
        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);  // Kiểm tra email theo pattern
        }

        // Kiểm tra có khoảng trắng thừa không
        private bool HasLeadingOrTrailingSpaces(string input)
        {
            return input != input.Trim();  
        }
        private bool IsValidLicensePlate(string plate)
        {
            if (plate.Length == 9)
            {
                if (plate.Substring(0, 2).All(Char.IsDigit) && Char.IsLetter(plate[2])
                    && plate[3] == '-' && plate.Substring(4).All(Char.IsDigit))
                {
                    return true;
                }
            }
            return false; 
        }

        private bool IsEmailDuplicate(string email)
        {
            string connectionString = "Data Source=DESKTOP-68MTOFF\\SQLEXPRESS;Initial Catalog=QUANLIGARA;Integrated Security=True"; // Thay thế thông tin kết nối của bạn

            string query = "SELECT COUNT(*) FROM XE WHERE Email = @Email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }


        private void xacnhanbtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường rỗng
            if (String.IsNullOrEmpty(biensotxtbox.Text) || String.IsNullOrEmpty(tentxtbox.Text)
                || String.IsNullOrEmpty(hieuxecbbox.Text) || String.IsNullOrEmpty(diachitxtbox.Text)
                || String.IsNullOrEmpty(dthtxtbox.Text) || String.IsNullOrEmpty(emailtxtbox.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!IsValidLicensePlate(biensotxtbox.Text))
            {
                MessageBox.Show("Biển số xe phải có 1 chữ cái và 7 chữ số!");
                return;
            }
            if (!IsValidName(tentxtbox.Text))
            {
                MessageBox.Show("Tên không được chứa số!");
                return;
            }



            if (!IsValidPhoneNumber(dthtxtbox.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }

            if (!IsValidPhoneNumberLength(dthtxtbox.Text))
            {
                MessageBox.Show("Số điện thoại phải có 10 ký tự!");
                return;
            }

            if (IsEmailDuplicate(emailtxtbox.Text))
            {
                MessageBox.Show("Email này đã được sử dụng. Vui lòng nhập email khác!");
                return;
            }

            // Kiểm tra email hợp lệ
            if (!IsValidEmail(emailtxtbox.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!");
                return;
            }

            if (HasLeadingOrTrailingSpaces(tentxtbox.Text) || HasLeadingOrTrailingSpaces(diachitxtbox.Text)
                || HasLeadingOrTrailingSpaces(dthtxtbox.Text) || HasLeadingOrTrailingSpaces(emailtxtbox.Text))
            {
                MessageBox.Show("Không được có khoảng trắng thừa trong các trường!");
                return;
            }

            string bs = biensotxtbox.Text;
            string t = tentxtbox.Text;
            string h = hieuxecbbox.Text;
            string d = diachitxtbox.Text;
            string dth = dthtxtbox.Text;
            string email = emailtxtbox.Text;

            if (TiepNhan(bs, t, h, d, dth, email))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Trùng biển số/ Vượt quá số xe tiếp nhận trong ngày", "Tiếp nhận xe thất bại!");
                this.Close();
            }
        }

    }
}

