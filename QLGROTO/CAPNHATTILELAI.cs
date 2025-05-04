using QLGROTO.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGROTO
{
    public partial class CAPNHATTILELAI : Form
    {
        public CAPNHATTILELAI()
        {
            InitializeComponent();
            HienThi();
        }
        void HienThi()
        {
            tilenumeric.Value = QUYDINHDAO.Instance.HienThiTiLeLai();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void capnhatbtn_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(tilenumeric.Value);

            if (QUYDINHDAO.Instance.CapNhatTiLeLai(f))
                this.Close();
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
                this.Close();
            }
        }

        private void thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CAPNHATTILELAI_Load(object sender, EventArgs e)
        {

        }
    }
}
