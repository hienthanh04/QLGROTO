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
    public partial class CHITIETPNK : Form
    {
        public string maphieunhap { get; set; }
        public string ngaynhap { get; set; }
        public CHITIETPNK()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnkvtptdtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CHITIETPNK_Load(object sender, EventArgs e)
        {
            mpntxtbox.Text = maphieunhap;

            ngaynhapdtpicker.Text = ngaynhap;
            pnkvtptdtgrid.DataSource = CT_PNKVTPTDAO.Instance.HienThi(maphieunhap);

        }
    }
}
