using ClosedXML.Excel;
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
    public partial class MANHINHCHINH : Form
    {
        int flag;
        public string tendangnhap { get; set; }

        public MANHINHCHINH()
        {

            InitializeComponent();
            xedtgrid.Columns["BienSo"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["TenChuXe"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["HieuXe"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["DiaChi"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["DienThoai"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["Email"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["TienNo"].DefaultCellStyle.ForeColor = Color.Black;
            xedtgrid.Columns["NgayTiepNhan"].DefaultCellStyle.ForeColor = Color.Black;
            HienThi();

        }
        public void HienThi()
        {
            DataTable dt = XEDAO.Instance.HienThi();
            xedtgrid.DataSource = dt;
        }

        public void HienThiXeTiepNhanTrongNgay()
        {
            DataTable dt = XEDAO.Instance.HienThiXeNhapTrongNgay();
            xedtgrid.DataSource = dt;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    dangsudungtxtbox.Text = "Khách";
            //else
            //{
                SqlDataReader dr = NHANVIENDAO.Instance.HienThiThongTin(tendangnhap);
                if (dr.Read())
                    dangsudungtxtbox.Text = dr["TenNV"].ToString();
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                TIEPNHANXE t = new TIEPNHANXE();
                t.ShowDialog();
                HienThi();
            //}

        }


        private void button4_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                PHIEUSUACHUA repairForm = new PHIEUSUACHUA();
                repairForm.ShowDialog();
                HienThi();
            //}
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                if (xedtgrid.Rows.Count == 0)
                    MessageBox.Show("Không có xe để cập nhật!");
                else
                {
                    SUATHONGTINXE changeForm = new SUATHONGTINXE();
                    changeForm.bienso = biensotxtbox.Text;
                    changeForm.ten = tentxtbox.Text;
                    changeForm.hieuxe = hieuxetxtbox.Text;
                    changeForm.diachi = diachitxtbox.Text;
                    changeForm.dth = dthtxtbox.Text;
                    changeForm.email = emailtxtbox.Text;
                    changeForm.no = notxtbox.Text;
                    changeForm.ngay = ngaydtpicker.Value;
                    changeForm.ShowDialog();
                    HienThi();
                }
            //}
        }


        private void danhSáchPhiếuNhậtKhoVTPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                DSPNKVTPT dSPHIEUNHAPKHO = new DSPNKVTPT();
                dSPHIEUNHAPKHO.ShowDialog();
            //}
        }


        private void danhSáchVậtTưPhụTùngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                DSVTPT a = new DSVTPT();
                a.ShowDialog();
            //}
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                string bienso = biensotxtbox.Text;
                if (xedtgrid.Rows.Count == 0)
                    MessageBox.Show("Không có xe để xóa");
                else
                {
                    if (!XEDAO.Instance.XoaXe(bienso))
                        MessageBox.Show("Không thể xóa xe!");
                    else
                    {
                        if (xedtgrid.Rows.Count == 0)
                        {
                            biensotxtbox.Clear();
                            tentxtbox.Clear();
                            dthtxtbox.Clear();
                            diachitxtbox.Clear();
                            emailtxtbox.Clear();
                            hieuxetxtbox.Clear();
                            notxtbox.Clear();
                        }
                        else
                        {
                            biensotxtbox.DataBindings.Clear();
                            biensotxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "BienSo");
                            tentxtbox.DataBindings.Clear();
                            tentxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "TenChuXe");
                            hieuxetxtbox.DataBindings.Clear();
                            hieuxetxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "HieuXe");
                            diachitxtbox.DataBindings.Clear();
                            diachitxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "DiaChi");
                            dthtxtbox.DataBindings.Clear();
                            dthtxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "DienThoai");
                            emailtxtbox.DataBindings.Clear();
                            emailtxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "Email");
                            notxtbox.DataBindings.Clear();
                            notxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "TienNo");
                            ngaydtpicker.DataBindings.Clear();
                            ngaydtpicker.DataBindings.Add("Value", xedtgrid.DataSource, "NgayTiepNhan");
                        }
                        HienThi();
                    }
                }
            //}
        }

        private void cậpNhậtTỉLệLãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            if (NHANVIENDAO.Instance.flag != 1)
                MessageBox.Show("Phải là quản lý mới có quyền truy cập!");
            else
            {
                CAPNHATTILELAI interestRateForm = new CAPNHATTILELAI();

                interestRateForm.ShowDialog();
            }
        }

        private void thayĐổiSốXeSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else 
            if (NHANVIENDAO.Instance.flag != 1)
                MessageBox.Show("Phải là quản lý mới có quyền truy cập!");
            else
            {
                CAPNHATQUYDINH maxCarForm = new CAPNHATQUYDINH();
                maxCarForm.ShowDialog();
            }
        }

        private void danhSáchLoạiTiềnCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                DSTIENCONG wageForm = new DSTIENCONG();
                wageForm.ShowDialog();
            //}
        }

        private void danhSáchHiệuXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                DSHIEUXE brandForm = new DSHIEUXE();
                brandForm.ShowDialog();
            //}
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                DSNHANVIEN dSNHANVIEN = new DSNHANVIEN();
                dSNHANVIEN.ShowDialog();
            //}
        }

        private void báoCáoTồnVậtTưPhụTùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                BAOCAOTON bAOCAOTON = new BAOCAOTON();
                bAOCAOTON.ShowDialog();
            //}
        }

        private void báoCáoDoanhSốThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                BAOCAODOANHSO b = new BAOCAODOANHSO();
                b.ShowDialog();
            //}
        }

        private void danhSáchLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                DSPHIEUSUACHUA dSPHIEUSUACHUA = new DSPHIEUSUACHUA();
                dSPHIEUSUACHUA.ShowDialog();
            //}
        }

        private void danhSáchPhiếuThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                DSPHIEUTHUTIEN dSPHIEUTHUTIEN = new DSPHIEUTHUTIEN();
                dSPHIEUTHUTIEN.ShowDialog();
            //}
        }


        private void NameSearchRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;

        }

        private void sdttimradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;

        }

        private void biensotimradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 3;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            flag = 4;
        }

        private void xedtgrid_SelectionChanged_1(object sender, EventArgs e)
        {
            biensotxtbox.DataBindings.Clear();
            biensotxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "BienSo");
            tentxtbox.DataBindings.Clear();
            tentxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "TenChuXe");
            hieuxetxtbox.DataBindings.Clear();
            hieuxetxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "HieuXe");
            diachitxtbox.DataBindings.Clear();
            diachitxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "DiaChi");
            dthtxtbox.DataBindings.Clear();
            dthtxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "DienThoai");
            emailtxtbox.DataBindings.Clear();
            emailtxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "Email");
            notxtbox.DataBindings.Clear();
            notxtbox.DataBindings.Add("Text", xedtgrid.DataSource, "TienNo");
            ngaydtpicker.DataBindings.Clear();
            ngaydtpicker.DataBindings.Add("Value", xedtgrid.DataSource, "NgayTiepNhan");
        }

        private void lapphieuvtptbtn_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                PHIEUNHAPVTPT p = new PHIEUNHAPVTPT();
                p.ShowDialog();
            //}
        }

        private void timkiembtn_Click(object sender, EventArgs e)
        {
            string s = timtxtbox.Text;
            if (!string.IsNullOrEmpty(s))
            {
                if (flag == 1)
                    xedtgrid.DataSource = XEDAO.Instance.TimKiemTheoTen(s);
                else if (flag == 2)
                    xedtgrid.DataSource = XEDAO.Instance.TimKiemTheoSDT(s);
                else if (flag == 3)
                    xedtgrid.DataSource = XEDAO.Instance.TimKiemTheoBienSo(s);
                else if (flag == 4)
                    xedtgrid.DataSource = XEDAO.Instance.TimKiemTheoNgay(s);
            }
            else
                HienThi();
        }

        private void xuatbtn_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                if (xedtgrid.Rows.Count == 0)
                    MessageBox.Show("Không có thông tin để xuất");
                else
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                using (XLWorkbook workbook = new XLWorkbook())
                                {
                                    workbook.Worksheets.Add(xedtgrid.DataSource as DataTable, "Xe");

                                    workbook.SaveAs(saveFileDialog.FileName);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Xuất file không thành công!");
                            }
                        }
                    }
                }
            //}
        }

        private void thutienbtn_Click(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else
            //{
                PHIEUTHUTIEN t = new PHIEUTHUTIEN();
                t.ShowDialog();
                HienThi();
            //}
        }

        private void dangxuatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else 
            if (NHANVIENDAO.Instance.flag != 1)
                MessageBox.Show("Phải là quản lý mới có quyền truy cập!");
            else
            {
                THONGTINADMIN t = new THONGTINADMIN();
                t.tendangnhap = tendangnhap;
                t.ShowDialog();
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //if (NHANVIENDAO.Instance.flag == 0)
            //    MessageBox.Show("Khách không được sử dụng chức năng này!");
            //else 
            if (NHANVIENDAO.Instance.flag != 1)
                MessageBox.Show("Phải là quản lý mới có quyền truy cập!");
            else
            {
                DSNHANVIEN t = new DSNHANVIEN();
                t.ShowDialog();
            }
        }

        private void xetiepnhantrongngaybtn_Click(object sender, EventArgs e)
        {
            HienThiXeTiepNhanTrongNgay();
        }

        private void xedtgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xedtgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PHIEUTHUTIEN phieuthu = new PHIEUTHUTIEN();
            phieuthu.biensocbbox.Text = this.xedtgrid.CurrentRow.Cells[0].Value.ToString();
            phieuthu.tentxtbox.Text = this.xedtgrid.CurrentRow.Cells[1].Value.ToString();
            phieuthu.hieuxetxtbox.Text = this.xedtgrid.CurrentRow.Cells[2].Value.ToString();
            phieuthu.diachitxtbox.Text = this.xedtgrid.CurrentRow.Cells[3].Value.ToString();
            phieuthu.dthtxtbox.Text = this.xedtgrid.CurrentRow.Cells[4].Value.ToString();
            phieuthu.emailtxtbox.Text = this.xedtgrid.CurrentRow.Cells[5].Value.ToString();
            phieuthu.tiennotxtbox.Text = this.xedtgrid.CurrentRow.Cells[6].Value.ToString();
            phieuthu.tienthutxtbox.Text = "0";
            phieuthu.tienconnotxtbox.Text = this.xedtgrid.CurrentRow.Cells[6].Value.ToString();
            phieuthu.ShowDialog();
            HienThi();
        }
    }
}
