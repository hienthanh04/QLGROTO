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
    public partial class DSPHIEUTHUTIEN : Form
    {
        int flag;
        public DSPHIEUTHUTIEN()
        {
            InitializeComponent();
            HienThi();
        }
        public void HienThi()
        {
            pttdtgrid.DataSource = PHIEUTHUTIENDAO.Instance.HienThi();
        }
        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string s = timkiemtxtbox.Text;
            int ngay = ngaydtpicker.Value.Day;
            int thang = ngaydtpicker.Value.Month;
            int nam = ngaydtpicker.Value.Year;
            if (flag == 2)
                pttdtgrid.DataSource = PHIEUTHUTIENDAO.Instance.TimKiemTheoNgay(ngay, thang, nam);
            else
            {
                if (!string.IsNullOrEmpty(s))
                {
                    if (flag == 1)
                        pttdtgrid.DataSource = PHIEUTHUTIENDAO.Instance.TimKiemTheoMa(s);

                }
                else
                    HienThi();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DSPHIEUTHUTIEN_Load(object sender, EventArgs e)
        {
            
        }

        private void xuatbtn_Click(object sender, EventArgs e)
        {
            if (pttdtgrid.Rows.Count == 0)
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
                                workbook.Worksheets.Add(pttdtgrid.DataSource as DataTable, "PHIEUTHUTIEN");

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

        private void mapnradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

      

        private void pttdtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timtheongayradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
        }
    }
}
