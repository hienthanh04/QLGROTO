namespace QLGROTO
{
    partial class DSPNKVTPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSPNKVTPT));
            panel1 = new Panel();
            VatTuPhuTung_Title = new Label();
            phieunhapvtptdtgrid = new DataGridView();
            MaNKVTPT = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            timkiembtn = new Button();
            timtheomaradio = new RadioButton();
            timkiemtxtbox = new TextBox();
            SearchLabel = new Label();
            xemctbtn = new Button();
            thoatbtn = new Button();
            xuatbtn = new Button();
            ngaydtpicker = new DateTimePicker();
            timngayradio = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phieunhapvtptdtgrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(VatTuPhuTung_Title);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 69);
            panel1.TabIndex = 0;
            // 
            // VatTuPhuTung_Title
            // 
            VatTuPhuTung_Title.Anchor = AnchorStyles.Top;
            VatTuPhuTung_Title.AutoSize = true;
            VatTuPhuTung_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            VatTuPhuTung_Title.ForeColor = Color.White;
            VatTuPhuTung_Title.Location = new Point(196, 11);
            VatTuPhuTung_Title.Margin = new Padding(4, 0, 4, 0);
            VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            VatTuPhuTung_Title.Size = new Size(810, 45);
            VatTuPhuTung_Title.TabIndex = 4;
            VatTuPhuTung_Title.Text = "DANH SÁCH PHIẾU NHẬP KHO VẬT TƯ PHỤ TÙNG";
            // 
            // phieunhapvtptdtgrid
            // 
            phieunhapvtptdtgrid.AllowUserToAddRows = false;
            phieunhapvtptdtgrid.AllowUserToDeleteRows = false;
            phieunhapvtptdtgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phieunhapvtptdtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            phieunhapvtptdtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phieunhapvtptdtgrid.Columns.AddRange(new DataGridViewColumn[] { MaNKVTPT, NgayNhap });
            phieunhapvtptdtgrid.Location = new Point(12, 164);
            phieunhapvtptdtgrid.Name = "phieunhapvtptdtgrid";
            phieunhapvtptdtgrid.ReadOnly = true;
            phieunhapvtptdtgrid.RowHeadersWidth = 51;
            phieunhapvtptdtgrid.RowTemplate.Height = 29;
            phieunhapvtptdtgrid.Size = new Size(1159, 423);
            phieunhapvtptdtgrid.TabIndex = 6;
            phieunhapvtptdtgrid.TabStop = false;
            // 
            // MaNKVTPT
            // 
            MaNKVTPT.DataPropertyName = "MaNKVTPT";
            MaNKVTPT.HeaderText = "Số phiếu nhập";
            MaNKVTPT.MinimumWidth = 6;
            MaNKVTPT.Name = "MaNKVTPT";
            MaNKVTPT.ReadOnly = true;
            // 
            // NgayNhap
            // 
            NgayNhap.DataPropertyName = "NgayNhap";
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.ReadOnly = true;
            // 
            // timkiembtn
            // 
            timkiembtn.Anchor = AnchorStyles.Top;
            timkiembtn.BackColor = SystemColors.Info;
            timkiembtn.Image = Properties.Resources.search_6699087_640__1_;
            timkiembtn.Location = new Point(803, 71);
            timkiembtn.Name = "timkiembtn";
            timkiembtn.Size = new Size(79, 27);
            timkiembtn.TabIndex = 1;
            timkiembtn.UseVisualStyleBackColor = false;
            timkiembtn.Click += timkiembtn_Click;
            // 
            // timtheomaradio
            // 
            timtheomaradio.Anchor = AnchorStyles.Top;
            timtheomaradio.AutoSize = true;
            timtheomaradio.ForeColor = SystemColors.ActiveCaptionText;
            timtheomaradio.Location = new Point(406, 101);
            timtheomaradio.Name = "timtheomaradio";
            timtheomaradio.Size = new Size(192, 24);
            timtheomaradio.TabIndex = 2;
            timtheomaradio.Text = "Tìm theo mã phiếu nhập";
            timtheomaradio.UseVisualStyleBackColor = true;
            timtheomaradio.CheckedChanged += timtheomaradio_CheckedChanged_1;
            // 
            // timkiemtxtbox
            // 
            timkiemtxtbox.Anchor = AnchorStyles.Top;
            timkiemtxtbox.BackColor = SystemColors.HighlightText;
            timkiemtxtbox.Location = new Point(426, 71);
            timkiemtxtbox.Name = "timkiemtxtbox";
            timkiemtxtbox.Size = new Size(371, 27);
            timkiemtxtbox.TabIndex = 0;
            // 
            // SearchLabel
            // 
            SearchLabel.Anchor = AnchorStyles.Top;
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SearchLabel.ForeColor = SystemColors.ActiveCaptionText;
            SearchLabel.Location = new Point(316, 70);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(104, 28);
            SearchLabel.TabIndex = 19;
            SearchLabel.Text = "Tìm kiếm:";
            // 
            // xemctbtn
            // 
            xemctbtn.Anchor = AnchorStyles.Bottom;
            xemctbtn.BackColor = SystemColors.HighlightText;
            xemctbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xemctbtn.ForeColor = SystemColors.ActiveCaptionText;
            xemctbtn.ImageAlign = ContentAlignment.MiddleLeft;
            xemctbtn.Location = new Point(333, 593);
            xemctbtn.Name = "xemctbtn";
            xemctbtn.Size = new Size(265, 65);
            xemctbtn.TabIndex = 2;
            xemctbtn.Text = "Xem chi tiết";
            xemctbtn.UseVisualStyleBackColor = false;
            xemctbtn.Click += xemctbtn_Click;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(1048, 613);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 4;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += button1_Click;
            // 
            // xuatbtn
            // 
            xuatbtn.Anchor = AnchorStyles.Bottom;
            xuatbtn.BackColor = SystemColors.Control;
            xuatbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xuatbtn.ForeColor = SystemColors.ActiveCaptionText;
            xuatbtn.ImageAlign = ContentAlignment.MiddleLeft;
            xuatbtn.Location = new Point(636, 593);
            xuatbtn.Name = "xuatbtn";
            xuatbtn.Size = new Size(265, 65);
            xuatbtn.TabIndex = 3;
            xuatbtn.Text = "Xuất file danh sách";
            xuatbtn.UseVisualStyleBackColor = false;
            xuatbtn.Click += xuatbtn_Click;
            // 
            // ngaydtpicker
            // 
            ngaydtpicker.Location = new Point(477, 131);
            ngaydtpicker.Name = "ngaydtpicker";
            ngaydtpicker.Size = new Size(250, 27);
            ngaydtpicker.TabIndex = 29;
            // 
            // timngayradio
            // 
            timngayradio.Anchor = AnchorStyles.Top;
            timngayradio.AutoSize = true;
            timngayradio.ForeColor = SystemColors.ActiveCaptionText;
            timngayradio.Location = new Point(604, 101);
            timngayradio.Name = "timngayradio";
            timngayradio.Size = new Size(191, 24);
            timngayradio.TabIndex = 30;
            timngayradio.Text = "Tìm theo ngày lập phiếu";
            timngayradio.UseVisualStyleBackColor = true;
            timngayradio.CheckedChanged += timngayradio_CheckedChanged;
            // 
            // DSPNKVTPT
            // 
            AcceptButton = timkiembtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(1183, 670);
            Controls.Add(timngayradio);
            Controls.Add(ngaydtpicker);
            Controls.Add(xuatbtn);
            Controls.Add(thoatbtn);
            Controls.Add(xemctbtn);
            Controls.Add(timkiembtn);
            Controls.Add(timtheomaradio);
            Controls.Add(timkiemtxtbox);
            Controls.Add(SearchLabel);
            Controls.Add(phieunhapvtptdtgrid);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DSPNKVTPT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách phiếu nhập kho vật tư phụ tùng";
            Load += DSPNKVTPT_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phieunhapvtptdtgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label VatTuPhuTung_Title;
        private DataGridView phieunhapvtptdtgrid;
        private Button timkiembtn;
        private RadioButton timtheomaradio;
        private TextBox timkiemtxtbox;
        private Label SearchLabel;
        private Button xemctbtn;
        private Button thoatbtn;
        private DataGridViewTextBoxColumn MaNKVTPT;
        private DataGridViewTextBoxColumn NgayNhap;
        private Button xuatbtn;
        private DateTimePicker ngaydtpicker;
        private RadioButton timngayradio;
    }
}