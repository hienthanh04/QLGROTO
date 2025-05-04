namespace QLGROTO
{
    partial class BAOCAOTON
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAOCAOTON));
            Group1 = new GroupBox();
            xuatbtn = new Button();
            namnumeric = new NumericUpDown();
            thangnumeric = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            themtiencong_btn = new Button();
            GroupBox2 = new GroupBox();
            bctdtgrid = new DataGridView();
            MaVTPT = new DataGridViewTextBoxColumn();
            TenVTPT = new DataGridViewTextBoxColumn();
            TonDau = new DataGridViewTextBoxColumn();
            PhatSinh = new DataGridViewTextBoxColumn();
            SuDung = new DataGridViewTextBoxColumn();
            TonCuoi = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ReportDoanhSo_Title = new Label();
            thoatbtn = new Button();
            Group1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)namnumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thangnumeric).BeginInit();
            GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bctdtgrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Group1
            // 
            Group1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Group1.Controls.Add(xuatbtn);
            Group1.Controls.Add(namnumeric);
            Group1.Controls.Add(thangnumeric);
            Group1.Controls.Add(label2);
            Group1.Controls.Add(label1);
            Group1.Controls.Add(themtiencong_btn);
            Group1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Group1.Location = new Point(13, 74);
            Group1.Margin = new Padding(4, 5, 4, 5);
            Group1.Name = "Group1";
            Group1.Padding = new Padding(4, 5, 4, 5);
            Group1.Size = new Size(1081, 99);
            Group1.TabIndex = 4;
            Group1.TabStop = false;
            Group1.Text = "Báo cáo tháng, năm";
            // 
            // xuatbtn
            // 
            xuatbtn.Anchor = AnchorStyles.Bottom;
            xuatbtn.BackColor = SystemColors.HighlightText;
            xuatbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xuatbtn.ForeColor = SystemColors.ActiveCaptionText;
            xuatbtn.ImageAlign = ContentAlignment.MiddleLeft;
            xuatbtn.Location = new Point(809, 26);
            xuatbtn.Name = "xuatbtn";
            xuatbtn.Size = new Size(265, 65);
            xuatbtn.TabIndex = 8;
            xuatbtn.Text = "Xuất báo cáo";
            xuatbtn.UseVisualStyleBackColor = false;
            xuatbtn.Click += xuatbtn_Click;
            // 
            // namnumeric
            // 
            namnumeric.BackColor = SystemColors.HighlightText;
            namnumeric.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            namnumeric.Location = new Point(359, 47);
            namnumeric.Margin = new Padding(3, 4, 3, 4);
            namnumeric.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            namnumeric.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            namnumeric.Name = "namnumeric";
            namnumeric.Size = new Size(137, 29);
            namnumeric.TabIndex = 61;
            namnumeric.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // thangnumeric
            // 
            thangnumeric.BackColor = SystemColors.HighlightText;
            thangnumeric.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            thangnumeric.Location = new Point(117, 47);
            thangnumeric.Margin = new Padding(3, 4, 3, 4);
            thangnumeric.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            thangnumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            thangnumeric.Name = "thangnumeric";
            thangnumeric.Size = new Size(137, 29);
            thangnumeric.TabIndex = 60;
            thangnumeric.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(295, 45);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 59;
            label2.Text = "Năm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 43);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 58;
            label1.Text = "Tháng:";
            // 
            // themtiencong_btn
            // 
            themtiencong_btn.Anchor = AnchorStyles.Top;
            themtiencong_btn.BackColor = SystemColors.ButtonFace;
            themtiencong_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            themtiencong_btn.ForeColor = SystemColors.ActiveCaptionText;
            themtiencong_btn.ImageAlign = ContentAlignment.MiddleLeft;
            themtiencong_btn.Location = new Point(538, 26);
            themtiencong_btn.Name = "themtiencong_btn";
            themtiencong_btn.Size = new Size(265, 65);
            themtiencong_btn.TabIndex = 38;
            themtiencong_btn.Text = "Hiện báo cáo";
            themtiencong_btn.UseVisualStyleBackColor = false;
            themtiencong_btn.Click += themtiencong_btn_Click;
            // 
            // GroupBox2
            // 
            GroupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBox2.Controls.Add(bctdtgrid);
            GroupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBox2.Location = new Point(13, 183);
            GroupBox2.Margin = new Padding(4, 5, 4, 5);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Padding = new Padding(4, 5, 4, 5);
            GroupBox2.Size = new Size(1081, 458);
            GroupBox2.TabIndex = 5;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Chi tiết báo cáo";
            // 
            // bctdtgrid
            // 
            bctdtgrid.AllowUserToAddRows = false;
            bctdtgrid.AllowUserToDeleteRows = false;
            bctdtgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bctdtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            bctdtgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            bctdtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bctdtgrid.Columns.AddRange(new DataGridViewColumn[] { MaVTPT, TenVTPT, TonDau, PhatSinh, SuDung, TonCuoi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            bctdtgrid.DefaultCellStyle = dataGridViewCellStyle2;
            bctdtgrid.Location = new Point(8, 28);
            bctdtgrid.Name = "bctdtgrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            bctdtgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            bctdtgrid.RowHeadersWidth = 51;
            bctdtgrid.RowTemplate.Height = 29;
            bctdtgrid.Size = new Size(1066, 421);
            bctdtgrid.TabIndex = 1;
            // 
            // MaVTPT
            // 
            MaVTPT.DataPropertyName = "MaVTPT";
            MaVTPT.HeaderText = "Mã VTPT";
            MaVTPT.MinimumWidth = 6;
            MaVTPT.Name = "MaVTPT";
            // 
            // TenVTPT
            // 
            TenVTPT.DataPropertyName = "TenVTPT";
            TenVTPT.HeaderText = "Tên VTPT";
            TenVTPT.MinimumWidth = 6;
            TenVTPT.Name = "TenVTPT";
            // 
            // TonDau
            // 
            TonDau.DataPropertyName = "TonDau";
            TonDau.HeaderText = "Tồn đầu";
            TonDau.MinimumWidth = 6;
            TonDau.Name = "TonDau";
            // 
            // PhatSinh
            // 
            PhatSinh.DataPropertyName = "PhatSinh";
            PhatSinh.HeaderText = "Phát sinh";
            PhatSinh.MinimumWidth = 6;
            PhatSinh.Name = "PhatSinh";
            // 
            // SuDung
            // 
            SuDung.DataPropertyName = "SuDung";
            SuDung.HeaderText = "Sử dụng";
            SuDung.MinimumWidth = 6;
            SuDung.Name = "SuDung";
            // 
            // TonCuoi
            // 
            TonCuoi.DataPropertyName = "TonCuoi";
            TonCuoi.HeaderText = "Tồn cuối";
            TonCuoi.MinimumWidth = 6;
            TonCuoi.Name = "TonCuoi";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(ReportDoanhSo_Title);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 66);
            panel1.TabIndex = 6;
            // 
            // ReportDoanhSo_Title
            // 
            ReportDoanhSo_Title.Anchor = AnchorStyles.Top;
            ReportDoanhSo_Title.AutoSize = true;
            ReportDoanhSo_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            ReportDoanhSo_Title.ForeColor = Color.White;
            ReportDoanhSo_Title.Location = new Point(411, 9);
            ReportDoanhSo_Title.Margin = new Padding(4, 0, 4, 0);
            ReportDoanhSo_Title.Name = "ReportDoanhSo_Title";
            ReportDoanhSo_Title.Size = new Size(326, 45);
            ReportDoanhSo_Title.TabIndex = 3;
            ReportDoanhSo_Title.Text = "BÁO CÁO TỒN KHO";
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(964, 638);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 7;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += button2_Click;
            // 
            // BAOCAOTON
            // 
            AcceptButton = thoatbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = thoatbtn;
            ClientSize = new Size(1107, 690);
            Controls.Add(thoatbtn);
            Controls.Add(panel1);
            Controls.Add(GroupBox2);
            Controls.Add(Group1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "BAOCAOTON";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo tồn kho";
            Group1.ResumeLayout(false);
            Group1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)namnumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)thangnumeric).EndInit();
            GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bctdtgrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox Group1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private Panel panel1;
        private Label ReportDoanhSo_Title;
        private Button themtiencong_btn;
        private Button thoatbtn;
        private DataGridView bctdtgrid;
        private NumericUpDown namnumeric;
        private NumericUpDown thangnumeric;
        private Label label2;
        private Label label1;
        private Button xuatbtn;
        private DataGridViewTextBoxColumn MaVTPT;
        private DataGridViewTextBoxColumn TenVTPT;
        private DataGridViewTextBoxColumn TonDau;
        private DataGridViewTextBoxColumn PhatSinh;
        private DataGridViewTextBoxColumn SuDung;
        private DataGridViewTextBoxColumn TonCuoi;
    }
}