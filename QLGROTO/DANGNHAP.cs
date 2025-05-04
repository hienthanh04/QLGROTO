
using QLGROTO.DAO;

namespace QLGROTO
{
    public partial class DANGNHAP : Form
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void lginbtn_Click(object sender, EventArgs e)
        {
            string username = tendangnhap_txtbox.Text;
            string password = pass_txtbox.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
            }
            else
            {
                if (NHANVIENDAO.Instance.DangNhap(username, password))
                {

                    if (NHANVIENDAO.Instance.flag == 1)
                        MessageBox.Show("Chào mừng admin!");
                    else
                        MessageBox.Show("Chào mừng nhân viên!");
                    MANHINHCHINH frm = new MANHINHCHINH();
                    this.Hide();
                    frm.tendangnhap = username;
                    
                    
                    frm.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
      
        private void escbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void chedokhachbtn_Click(object sender, EventArgs e)
        {
            MANHINHCHINH frm = new MANHINHCHINH();
            this.Hide();
            NHANVIENDAO.Instance.flag = 0;

            frm.ShowDialog();
            this.Show();
        }
    }
}