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
    public partial class CAPNHATQUYDINH : Form
    {
        public CAPNHATQUYDINH()
        {
            InitializeComponent();
            HienThi();
        }
        void HienThi()
        {
            maxxenumeric.Value = QUYDINHDAO.Instance.HienThiSoXe();
            hieuxenumeric.Value = QUYDINHDAO.Instance.HienThiSoHieuXe();
            tiencongnumeric.Value = QUYDINHDAO.Instance.HienThiSoLoaiTienCong();
            vtptnumeric.Value = QUYDINHDAO.Instance.HienThiSoLoaiVTPT();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void capnhatbtn_Click(object sender, EventArgs e)
        {
            int soXe = Convert.ToInt32(maxxenumeric.Value);
            int soHieuXe = Convert.ToInt32(hieuxenumeric.Value);
            int soTienCong = Convert.ToInt32(tiencongnumeric.Value);
            int soVTPT = Convert.ToInt32(vtptnumeric.Value);

            bool success = QUYDINHDAO.Instance.CapNhatTatCaQuyDinh(soXe, soHieuXe, soTienCong, soVTPT);

            if (success)
            {
                MessageBox.Show("Cập nhật quy định thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }
        
        private void thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
