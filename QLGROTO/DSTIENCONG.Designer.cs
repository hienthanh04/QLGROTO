namespace QLGROTO
{
    partial class DSTIENCONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSTIENCONG));
            panel1 = new Panel();
            label1 = new Label();
            ndtcbtn = new RadioButton();
            matcradio = new RadioButton();
            timkiemtxtbox = new TextBox();
            SearchLabel = new Label();
            tcdtgrid = new DataGridView();
            MaTienCong = new DataGridViewTextBoxColumn();
            TienCong = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            xoatcbtn = new Button();
            thoatbtn = new Button();
            label7 = new Label();
            label8 = new Label();
            TenChuXe = new Label();
            tctxtbox = new TextBox();
            matctxtbox = new TextBox();
            ndtxtbox = new TextBox();
            themtcbtn = new Button();
            suatcbtn = new Button();
            groupBox1 = new GroupBox();
            timkiembtn = new Button();
            xuatbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tcdtgrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(346, 11);
            label1.Name = "label1";
            label1.Size = new Size(483, 45);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH LOẠI TIỀN CÔNG";
            // 
            // ndtcbtn
            // 
            ndtcbtn.Anchor = AnchorStyles.Top;
            ndtcbtn.AutoSize = true;
            ndtcbtn.ForeColor = SystemColors.ActiveCaptionText;
            ndtcbtn.Location = new Point(620, 98);
            ndtcbtn.Name = "ndtcbtn";
            ndtcbtn.Size = new Size(152, 24);
            ndtcbtn.TabIndex = 2;
            ndtcbtn.Text = "Tìm theo nội dung";
            ndtcbtn.UseVisualStyleBackColor = true;
            ndtcbtn.CheckedChanged += ndtcbtn_CheckedChanged;
            // 
            // matcradio
            // 
            matcradio.Anchor = AnchorStyles.Top;
            matcradio.AutoSize = true;
            matcradio.ForeColor = SystemColors.ActiveCaptionText;
            matcradio.Location = new Point(405, 98);
            matcradio.Name = "matcradio";
            matcradio.Size = new Size(209, 24);
            matcradio.TabIndex = 2;
            matcradio.Text = "Tìm theo mã loại tiền công";
            matcradio.UseVisualStyleBackColor = true;
            matcradio.CheckedChanged += matcradio_CheckedChanged;
            // 
            // timkiemtxtbox
            // 
            timkiemtxtbox.Anchor = AnchorStyles.Top;
            timkiemtxtbox.BackColor = SystemColors.HighlightText;
            timkiemtxtbox.Location = new Point(417, 68);
            timkiemtxtbox.Name = "timkiemtxtbox";
            timkiemtxtbox.Size = new Size(371, 27);
            timkiemtxtbox.TabIndex = 0;
            timkiemtxtbox.TextChanged += timkiemtxtbox_TextChanged;
            // 
            // SearchLabel
            // 
            SearchLabel.Anchor = AnchorStyles.Top;
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SearchLabel.ForeColor = SystemColors.ActiveCaptionText;
            SearchLabel.Location = new Point(307, 67);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(104, 28);
            SearchLabel.TabIndex = 7;
            SearchLabel.Text = "Tìm kiếm:";
            // 
            // tcdtgrid
            // 
            tcdtgrid.AllowUserToAddRows = false;
            tcdtgrid.AllowUserToDeleteRows = false;
            tcdtgrid.AllowUserToOrderColumns = true;
            tcdtgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcdtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tcdtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tcdtgrid.Columns.AddRange(new DataGridViewColumn[] { MaTienCong, TienCong, NoiDung });
            tcdtgrid.Location = new Point(12, 128);
            tcdtgrid.Name = "tcdtgrid";
            tcdtgrid.RowHeadersWidth = 51;
            tcdtgrid.RowTemplate.Height = 29;
            tcdtgrid.Size = new Size(1147, 427);
            tcdtgrid.TabIndex = 4;
            tcdtgrid.TabStop = false;
            tcdtgrid.SelectionChanged += tcdtgrid_SelectionChanged;
            // 
            // MaTienCong
            // 
            MaTienCong.DataPropertyName = "MaTienCong";
            MaTienCong.HeaderText = "Mã tiền công";
            MaTienCong.MinimumWidth = 6;
            MaTienCong.Name = "MaTienCong";
            // 
            // TienCong
            // 
            TienCong.DataPropertyName = "TienCong";
            TienCong.HeaderText = "Tiền công";
            TienCong.MinimumWidth = 6;
            TienCong.Name = "TienCong";
            // 
            // NoiDung
            // 
            NoiDung.DataPropertyName = "NoiDung";
            NoiDung.HeaderText = "Nội dung";
            NoiDung.MinimumWidth = 6;
            NoiDung.Name = "NoiDung";
            NoiDung.ReadOnly = true;
            // 
            // xoatcbtn
            // 
            xoatcbtn.Anchor = AnchorStyles.Bottom;
            xoatcbtn.BackColor = Color.FromArgb(192, 0, 0);
            xoatcbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xoatcbtn.ForeColor = Color.White;
            xoatcbtn.ImageAlign = ContentAlignment.MiddleLeft;
            xoatcbtn.Location = new Point(617, 632);
            xoatcbtn.Name = "xoatcbtn";
            xoatcbtn.Size = new Size(265, 65);
            xoatcbtn.TabIndex = 4;
            xoatcbtn.Text = "Xoá loại tiền công";
            xoatcbtn.UseVisualStyleBackColor = false;
            xoatcbtn.Click += xoatcbtn_Click;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(1030, 709);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 6;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += button1_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(106, 55);
            label7.Name = "label7";
            label7.Size = new Size(119, 31);
            label7.TabIndex = 64;
            label7.Text = "Tiền công:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(28, 25);
            label8.Name = "label8";
            label8.Size = new Size(197, 31);
            label8.TabIndex = 65;
            label8.Text = "Mã loại tiền công:";
            // 
            // TenChuXe
            // 
            TenChuXe.Anchor = AnchorStyles.Bottom;
            TenChuXe.AutoSize = true;
            TenChuXe.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TenChuXe.Location = new Point(28, 86);
            TenChuXe.Name = "TenChuXe";
            TenChuXe.Size = new Size(115, 31);
            TenChuXe.TabIndex = 66;
            TenChuXe.Text = "Nội dung:";
            // 
            // tctxtbox
            // 
            tctxtbox.Anchor = AnchorStyles.Bottom;
            tctxtbox.BackColor = Color.Gainsboro;
            tctxtbox.Enabled = false;
            tctxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tctxtbox.Location = new Point(231, 57);
            tctxtbox.Multiline = true;
            tctxtbox.Name = "tctxtbox";
            tctxtbox.ReadOnly = true;
            tctxtbox.ScrollBars = ScrollBars.Horizontal;
            tctxtbox.Size = new Size(360, 25);
            tctxtbox.TabIndex = 61;
            // 
            // matctxtbox
            // 
            matctxtbox.Anchor = AnchorStyles.Bottom;
            matctxtbox.BackColor = Color.Gainsboro;
            matctxtbox.Enabled = false;
            matctxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            matctxtbox.Location = new Point(231, 27);
            matctxtbox.Multiline = true;
            matctxtbox.Name = "matctxtbox";
            matctxtbox.ReadOnly = true;
            matctxtbox.ScrollBars = ScrollBars.Horizontal;
            matctxtbox.Size = new Size(360, 25);
            matctxtbox.TabIndex = 62;
            // 
            // ndtxtbox
            // 
            ndtxtbox.Anchor = AnchorStyles.Bottom;
            ndtxtbox.BackColor = Color.Gainsboro;
            ndtxtbox.Enabled = false;
            ndtxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ndtxtbox.Location = new Point(149, 89);
            ndtxtbox.Multiline = true;
            ndtxtbox.Name = "ndtxtbox";
            ndtxtbox.ReadOnly = true;
            ndtxtbox.ScrollBars = ScrollBars.Horizontal;
            ndtxtbox.Size = new Size(442, 76);
            ndtxtbox.TabIndex = 63;
            // 
            // themtcbtn
            // 
            themtcbtn.Anchor = AnchorStyles.Bottom;
            themtcbtn.BackColor = Color.FromArgb(0, 192, 0);
            themtcbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            themtcbtn.ForeColor = Color.White;
            themtcbtn.ImageAlign = ContentAlignment.MiddleLeft;
            themtcbtn.Location = new Point(620, 561);
            themtcbtn.Name = "themtcbtn";
            themtcbtn.Size = new Size(265, 65);
            themtcbtn.TabIndex = 2;
            themtcbtn.Text = "Thêm loại tiền công";
            themtcbtn.UseVisualStyleBackColor = false;
            themtcbtn.Click += themtiencong_btn_Click;
            // 
            // suatcbtn
            // 
            suatcbtn.Anchor = AnchorStyles.Bottom;
            suatcbtn.BackColor = Color.Yellow;
            suatcbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            suatcbtn.ForeColor = SystemColors.ActiveCaptionText;
            suatcbtn.ImageAlign = ContentAlignment.MiddleLeft;
            suatcbtn.Location = new Point(888, 561);
            suatcbtn.Name = "suatcbtn";
            suatcbtn.Size = new Size(265, 65);
            suatcbtn.TabIndex = 3;
            suatcbtn.Text = "Cập nhật loại tiền công";
            suatcbtn.UseVisualStyleBackColor = false;
            suatcbtn.Click += suatiencong_btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(ndtxtbox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(matctxtbox);
            groupBox1.Controls.Add(tctxtbox);
            groupBox1.Controls.Add(TenChuXe);
            groupBox1.Location = new Point(6, 561);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 171);
            groupBox1.TabIndex = 68;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // timkiembtn
            // 
            timkiembtn.Anchor = AnchorStyles.Top;
            timkiembtn.BackColor = SystemColors.Info;
            timkiembtn.Image = Properties.Resources.search_6699087_640__1_;
            timkiembtn.Location = new Point(794, 68);
            timkiembtn.Name = "timkiembtn";
            timkiembtn.Size = new Size(79, 27);
            timkiembtn.TabIndex = 1;
            timkiembtn.UseVisualStyleBackColor = false;
            timkiembtn.Click += timkiembtn_Click;
            // 
            // xuatbtn
            // 
            xuatbtn.Anchor = AnchorStyles.Bottom;
            xuatbtn.BackColor = SystemColors.Control;
            xuatbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xuatbtn.ForeColor = SystemColors.ActiveCaptionText;
            xuatbtn.ImageAlign = ContentAlignment.MiddleLeft;
            xuatbtn.Location = new Point(888, 632);
            xuatbtn.Name = "xuatbtn";
            xuatbtn.Size = new Size(265, 65);
            xuatbtn.TabIndex = 5;
            xuatbtn.Text = "Xuất file danh sách";
            xuatbtn.UseVisualStyleBackColor = false;
            xuatbtn.Click += xuatbtn_Click;
            // 
            // DSTIENCONG
            // 
            AcceptButton = timkiembtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(1171, 766);
            Controls.Add(xuatbtn);
            Controls.Add(timkiembtn);
            Controls.Add(groupBox1);
            Controls.Add(suatcbtn);
            Controls.Add(thoatbtn);
            Controls.Add(xoatcbtn);
            Controls.Add(themtcbtn);
            Controls.Add(tcdtgrid);
            Controls.Add(ndtcbtn);
            Controls.Add(matcradio);
            Controls.Add(timkiemtxtbox);
            Controls.Add(SearchLabel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DSTIENCONG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách loại tiền công";
            Load += WageForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tcdtgrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RadioButton ndtcbtn;
        private RadioButton matcradio;
        private TextBox timkiemtxtbox;
        private Label SearchLabel;
        private DataGridView tcdtgrid;
        private Button xoatcbtn;
        private Button thoatbtn;
        private Label label7;
        private Label label8;
        private Label TenChuXe;
        private TextBox tctxtbox;
        private TextBox matctxtbox;
        private TextBox ndtxtbox;
        private Button themtcbtn;
        private Button suatcbtn;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn MaTienCong;
        private DataGridViewTextBoxColumn TienCong;
        private DataGridViewTextBoxColumn NoiDung;
        private Button timkiembtn;
        private Button xuatbtn;
    }
}