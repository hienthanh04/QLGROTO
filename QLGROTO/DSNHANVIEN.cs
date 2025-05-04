using ClosedXML.Excel;
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
    public partial class DSNHANVIEN : Form
    {
        int flag;
        public DSNHANVIEN()
        {
            InitializeComponent();
            HienThi();
        }
        public void HienThi()
        {
            nvdtgrid.DataSource = NHANVIENDAO.Instance.HienThi();
        }

        private void themtiencong_btn_Click(object sender, EventArgs e)
        {
            THEMNV tHEMNV = new THEMNV();
            tHEMNV.ShowDialog();
            HienThi();
        }
      
        private void xuatbtn_Click(object sender, EventArgs e)
        {
            if (nvdtgrid.Rows.Count == 0)
                MessageBox.Show("Không có thông tin để xuất!");
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
                                workbook.Worksheets.Add(nvdtgrid.DataSource as DataTable, "NhanVien");

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
        }

        private void nvdtgrid_SelectionChanged(object sender, EventArgs e)
        {
           
                tdntxtbox.DataBindings.Clear();
                tdntxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "TenDangNhap");
                mktxtbox.DataBindings.Clear();
                mktxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "MatKhau");
                tentxtbox.DataBindings.Clear();
                tentxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "TenNV");
                dctxtbox.DataBindings.Clear();
                dctxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "DiaChi");
                dthtxtbox.DataBindings.Clear();
                dthtxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "DienThoai");
                emailtxtbox.DataBindings.Clear();
                emailtxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "Email");
                chucvutxtbox.DataBindings.Clear();
                chucvutxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "ChucVu");
            
        }

        private void xoanvbtn_Click(object sender, EventArgs e)
        {
            if (nvdtgrid.Rows.Count > 0)
            {
                NHANVIENDAO.Instance.Xoa(tdntxtbox.Text);
                HienThi();
                if (nvdtgrid.Rows.Count == 0)
                {
                    tdntxtbox.Clear();
                    mktxtbox.Clear();
                    tentxtbox.Clear();
                    dctxtbox.Clear();
                    dthtxtbox.Clear();
                    emailtxtbox.Clear();
                    chucvutxtbox.Clear();
                }
                else
                {
                    tdntxtbox.DataBindings.Clear();
                    tdntxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "TenDangNhap");
                    mktxtbox.DataBindings.Clear();
                    mktxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "MatKhau");
                    tentxtbox.DataBindings.Clear();
                    tentxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "TenNV");
                    dctxtbox.DataBindings.Clear();
                    dctxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "DiaChi");
                    dthtxtbox.DataBindings.Clear();
                    dthtxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "DienThoai");
                    emailtxtbox.DataBindings.Clear();
                    emailtxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "Email");
                    chucvutxtbox.DataBindings.Clear();
                    chucvutxtbox.DataBindings.Add("Text", nvdtgrid.DataSource, "ChucVu");
                }
            }
            else
                MessageBox.Show("Không có nhân viên để xóa!");
        }

        private void suanvbtn_Click(object sender, EventArgs e)
        {
            if (nvdtgrid.Rows.Count == 0)
                MessageBox.Show("Không có nhân viên để cập nhật!");
            else
            {
                SUANV sUANV = new SUANV();
                sUANV.ten = tentxtbox.Text;
                sUANV.tendangnhap = tdntxtbox.Text;
                sUANV.matkhau = mktxtbox.Text;
                sUANV.diachi = dctxtbox.Text;
                sUANV.dth = dthtxtbox.Text;
                sUANV.email = emailtxtbox.Text;
                sUANV.chucvu = chucvutxtbox.Text;

                sUANV.ShowDialog();
                HienThi();
            }
        }

        private void sdtradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 3;
        }

        private void tennvradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void manvradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void timkiembtn_Click(object sender, EventArgs e)
        {
            string s = timkiemtxtbox.Text;
            if (!string.IsNullOrEmpty(timkiemtxtbox.Text))
            {
                if (flag == 1)
                {
                    nvdtgrid.DataSource = NHANVIENDAO.Instance.TimKiemTheoTenDangNhap(s);

                }
                else if (flag == 2)
                {
                    nvdtgrid.DataSource = NHANVIENDAO.Instance.TimKiemTheoTen(s);

                }
                else if (flag == 3)
                {
                    nvdtgrid.DataSource = NHANVIENDAO.Instance.TimKiemTheoSDT(s);
                }
            }
            else
                HienThi();
        }

        private void DSNHANVIEN_Load(object sender, EventArgs e)
        {

        }

        private void nvdtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nvdtgrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
