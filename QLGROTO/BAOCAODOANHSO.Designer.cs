namespace QLGROTO
{
    partial class BAOCAODOANHSO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAOCAODOANHSO));
            panel1 = new Panel();
            ReportDoanhSo_Title = new Label();
            groupBox1 = new GroupBox();
            xuatbtn = new Button();
            namnumeric = new NumericUpDown();
            thangnumeric = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            hienbcbtn = new Button();
            groupBox2 = new GroupBox();
            bcdsdtgrid = new DataGridView();
            HieuXe = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            SoLuot = new DataGridViewTextBoxColumn();
            TiLe = new DataGridViewTextBoxColumn();
            thoatbtn = new Button();
            ttttxtbox = new TextBox();
            label11 = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)namnumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thangnumeric).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bcdsdtgrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(ReportDoanhSo_Title);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 66);
            panel1.TabIndex = 0;
            // 
            // ReportDoanhSo_Title
            // 
            ReportDoanhSo_Title.Anchor = AnchorStyles.Top;
            ReportDoanhSo_Title.AutoSize = true;
            ReportDoanhSo_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            ReportDoanhSo_Title.ForeColor = Color.White;
            ReportDoanhSo_Title.Location = new Point(339, 10);
            ReportDoanhSo_Title.Margin = new Padding(4, 0, 4, 0);
            ReportDoanhSo_Title.Name = "ReportDoanhSo_Title";
            ReportDoanhSo_Title.Size = new Size(477, 45);
            ReportDoanhSo_Title.TabIndex = 4;
            ReportDoanhSo_Title.Text = "BÁO CÁO DOANH SỐ THÁNG";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(xuatbtn);
            groupBox1.Controls.Add(namnumeric);
            groupBox1.Controls.Add(thangnumeric);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(hienbcbtn);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1081, 99);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Báo cáo tháng, năm";
            // 
            // xuatbtn
            // 
            xuatbtn.Anchor = AnchorStyles.Top;
            xuatbtn.BackColor = SystemColors.HighlightText;
            xuatbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xuatbtn.ForeColor = SystemColors.ActiveCaptionText;
            xuatbtn.ImageAlign = ContentAlignment.MiddleLeft;
            xuatbtn.Location = new Point(810, 26);
            xuatbtn.Name = "xuatbtn";
            xuatbtn.Size = new Size(265, 65);
            xuatbtn.TabIndex = 58;
            xuatbtn.Text = "Xuất báo cáo";
            xuatbtn.UseVisualStyleBackColor = false;
            xuatbtn.Click += xuatbtn_Click;
            // 
            // namnumeric
            // 
            namnumeric.Anchor = AnchorStyles.Top;
            namnumeric.BackColor = SystemColors.HighlightText;
            namnumeric.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            namnumeric.Location = new Point(362, 47);
            namnumeric.Margin = new Padding(3, 4, 3, 4);
            namnumeric.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            namnumeric.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            namnumeric.Name = "namnumeric";
            namnumeric.Size = new Size(137, 29);
            namnumeric.TabIndex = 57;
            namnumeric.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // thangnumeric
            // 
            thangnumeric.Anchor = AnchorStyles.Top;
            thangnumeric.BackColor = SystemColors.HighlightText;
            thangnumeric.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            thangnumeric.Location = new Point(120, 47);
            thangnumeric.Margin = new Padding(3, 4, 3, 4);
            thangnumeric.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            thangnumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            thangnumeric.Name = "thangnumeric";
            thangnumeric.Size = new Size(137, 29);
            thangnumeric.TabIndex = 56;
            thangnumeric.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(298, 45);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 55;
            label2.Text = "Năm:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 43);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 54;
            label1.Text = "Tháng:";
            // 
            // hienbcbtn
            // 
            hienbcbtn.Anchor = AnchorStyles.Top;
            hienbcbtn.BackColor = SystemColors.ButtonFace;
            hienbcbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            hienbcbtn.ForeColor = SystemColors.ActiveCaptionText;
            hienbcbtn.ImageAlign = ContentAlignment.MiddleLeft;
            hienbcbtn.Location = new Point(539, 26);
            hienbcbtn.Name = "hienbcbtn";
            hienbcbtn.Size = new Size(265, 65);
            hienbcbtn.TabIndex = 41;
            hienbcbtn.Text = "Hiện báo cáo";
            hienbcbtn.UseVisualStyleBackColor = false;
            hienbcbtn.Click += hienbcbtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(bcdsdtgrid);
            groupBox2.Location = new Point(12, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1081, 467);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết báo cáo";
            // 
            // bcdsdtgrid
            // 
            bcdsdtgrid.AllowUserToAddRows = false;
            bcdsdtgrid.AllowUserToDeleteRows = false;
            bcdsdtgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bcdsdtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bcdsdtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bcdsdtgrid.Columns.AddRange(new DataGridViewColumn[] { HieuXe, ThanhTien, SoLuot, TiLe });
            bcdsdtgrid.Location = new Point(8, 26);
            bcdsdtgrid.Name = "bcdsdtgrid";
            bcdsdtgrid.ReadOnly = true;
            bcdsdtgrid.RowHeadersWidth = 51;
            bcdsdtgrid.RowTemplate.Height = 29;
            bcdsdtgrid.Size = new Size(1067, 435);
            bcdsdtgrid.TabIndex = 1;
            // 
            // HieuXe
            // 
            HieuXe.DataPropertyName = "HieuXe";
            HieuXe.HeaderText = "Hiệu xe";
            HieuXe.MinimumWidth = 6;
            HieuXe.Name = "HieuXe";
            HieuXe.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // SoLuot
            // 
            SoLuot.DataPropertyName = "SoLuot";
            SoLuot.HeaderText = "Số lượt sửa chữa";
            SoLuot.MinimumWidth = 6;
            SoLuot.Name = "SoLuot";
            SoLuot.ReadOnly = true;
            // 
            // TiLe
            // 
            TiLe.DataPropertyName = "TiLe";
            TiLe.HeaderText = "Tỉ lệ";
            TiLe.MinimumWidth = 6;
            TiLe.Name = "TiLe";
            TiLe.ReadOnly = true;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(964, 640);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 3;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += button2_Click;
            // 
            // ttttxtbox
            // 
            ttttxtbox.Anchor = AnchorStyles.Bottom;
            ttttxtbox.Enabled = false;
            ttttxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ttttxtbox.Location = new Point(432, 650);
            ttttxtbox.Name = "ttttxtbox";
            ttttxtbox.Size = new Size(397, 27);
            ttttxtbox.TabIndex = 17;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(272, 646);
            label11.Name = "label11";
            label11.Size = new Size(154, 28);
            label11.TabIndex = 16;
            label11.Text = "Tổng thành tiền:";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.Location = new Point(755, 650);
            button4.Name = "button4";
            button4.Size = new Size(9, 8);
            button4.TabIndex = 18;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // BAOCAODOANHSO
            // 
            AcceptButton = thoatbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = thoatbtn;
            ClientSize = new Size(1107, 690);
            Controls.Add(ttttxtbox);
            Controls.Add(label11);
            Controls.Add(thoatbtn);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BAOCAODOANHSO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo doanh số tháng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)namnumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)thangnumeric).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bcdsdtgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label ReportDoanhSo_Title;
        private GroupBox groupBox1;
        private Button hienbcbtn;
        private GroupBox groupBox2;
        private Button thoatbtn;
        private NumericUpDown namnumeric;
        private NumericUpDown thangnumeric;
        private Label label2;
        private Label label1;
        private DataGridView bcdsdtgrid;
        private Button xuatbtn;
        private TextBox ttttxtbox;
        private Label label11;
        private Button button4;
        private DataGridViewTextBoxColumn HieuXe;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn SoLuot;
        private DataGridViewTextBoxColumn TiLe;
    }
}