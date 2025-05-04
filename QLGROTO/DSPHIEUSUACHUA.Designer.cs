namespace QLGROTO
{
    partial class DSPHIEUSUACHUA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSPHIEUSUACHUA));
            panel1 = new Panel();
            VatTuPhuTung_Title = new Label();
            timkiembtn = new Button();
            mapscradio = new RadioButton();
            timkiemtxtbox = new TextBox();
            SearchLabel = new Label();
            xembtn = new Button();
            thoatbtn = new Button();
            pscdtgrid = new DataGridView();
            MaPSC = new DataGridViewTextBoxColumn();
            BienSo = new DataGridViewTextBoxColumn();
            NgaySuaChua = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            xuatbtn = new Button();
            timtheongayradio = new RadioButton();
            ngaydtpicker = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pscdtgrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(VatTuPhuTung_Title);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 67);
            panel1.TabIndex = 0;
            // 
            // VatTuPhuTung_Title
            // 
            VatTuPhuTung_Title.Anchor = AnchorStyles.Top;
            VatTuPhuTung_Title.AutoSize = true;
            VatTuPhuTung_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            VatTuPhuTung_Title.ForeColor = Color.White;
            VatTuPhuTung_Title.Location = new Point(349, 9);
            VatTuPhuTung_Title.Margin = new Padding(4, 0, 4, 0);
            VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            VatTuPhuTung_Title.Size = new Size(502, 45);
            VatTuPhuTung_Title.TabIndex = 4;
            VatTuPhuTung_Title.Text = "DANH SÁCH PHIẾU SỬA CHỮA";
            // 
            // timkiembtn
            // 
            timkiembtn.Anchor = AnchorStyles.Top;
            timkiembtn.BackColor = SystemColors.Info;
            timkiembtn.Image = Properties.Resources.search_6699087_640__1_;
            timkiembtn.Location = new Point(809, 71);
            timkiembtn.Name = "timkiembtn";
            timkiembtn.Size = new Size(79, 27);
            timkiembtn.TabIndex = 1;
            timkiembtn.UseVisualStyleBackColor = false;
            timkiembtn.Click += timkiembtn_Click;
            // 
            // mapscradio
            // 
            mapscradio.Anchor = AnchorStyles.Top;
            mapscradio.AutoSize = true;
            mapscradio.ForeColor = SystemColors.ActiveCaptionText;
            mapscradio.Location = new Point(408, 104);
            mapscradio.Name = "mapscradio";
            mapscradio.Size = new Size(218, 24);
            mapscradio.TabIndex = 2;
            mapscradio.Text = "Tìm theo mã phiếu sửa chữa";
            mapscradio.UseVisualStyleBackColor = true;
            mapscradio.CheckedChanged += mapscradio_CheckedChanged;
            // 
            // timkiemtxtbox
            // 
            timkiemtxtbox.Anchor = AnchorStyles.Top;
            timkiemtxtbox.BackColor = SystemColors.HighlightText;
            timkiemtxtbox.Location = new Point(432, 71);
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
            SearchLabel.Location = new Point(322, 70);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(104, 28);
            SearchLabel.TabIndex = 26;
            SearchLabel.Text = "Tìm kiếm:";
            // 
            // xembtn
            // 
            xembtn.Anchor = AnchorStyles.Bottom;
            xembtn.BackColor = SystemColors.HighlightText;
            xembtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xembtn.ForeColor = SystemColors.ActiveCaptionText;
            xembtn.ImageAlign = ContentAlignment.MiddleLeft;
            xembtn.Location = new Point(322, 593);
            xembtn.Name = "xembtn";
            xembtn.Size = new Size(265, 65);
            xembtn.TabIndex = 2;
            xembtn.Text = "Xem chi tiết";
            xembtn.UseVisualStyleBackColor = false;
            xembtn.Click += xembtn_Click;
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
            // pscdtgrid
            // 
            pscdtgrid.AllowUserToAddRows = false;
            pscdtgrid.AllowUserToDeleteRows = false;
            pscdtgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pscdtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pscdtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pscdtgrid.Columns.AddRange(new DataGridViewColumn[] { MaPSC, BienSo, NgaySuaChua, TongTien });
            pscdtgrid.Location = new Point(12, 171);
            pscdtgrid.Name = "pscdtgrid";
            pscdtgrid.ReadOnly = true;
            pscdtgrid.RowHeadersWidth = 51;
            pscdtgrid.RowTemplate.Height = 29;
            pscdtgrid.Size = new Size(1159, 416);
            pscdtgrid.TabIndex = 8;
            pscdtgrid.TabStop = false;
            // 
            // MaPSC
            // 
            MaPSC.DataPropertyName = "MaPSC";
            MaPSC.HeaderText = "Mã phiếu sửa chữa";
            MaPSC.MinimumWidth = 6;
            MaPSC.Name = "MaPSC";
            MaPSC.ReadOnly = true;
            // 
            // BienSo
            // 
            BienSo.DataPropertyName = "BienSo";
            BienSo.HeaderText = "Biển số xe";
            BienSo.MinimumWidth = 6;
            BienSo.Name = "BienSo";
            BienSo.ReadOnly = true;
            // 
            // NgaySuaChua
            // 
            NgaySuaChua.DataPropertyName = "NgaySuaChua";
            NgaySuaChua.HeaderText = "Ngày sửa chữa";
            NgaySuaChua.MinimumWidth = 6;
            NgaySuaChua.Name = "NgaySuaChua";
            NgaySuaChua.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng thành tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // xuatbtn
            // 
            xuatbtn.Anchor = AnchorStyles.Bottom;
            xuatbtn.BackColor = SystemColors.Control;
            xuatbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xuatbtn.ForeColor = SystemColors.ActiveCaptionText;
            xuatbtn.ImageAlign = ContentAlignment.MiddleLeft;
            xuatbtn.Location = new Point(623, 593);
            xuatbtn.Name = "xuatbtn";
            xuatbtn.Size = new Size(265, 65);
            xuatbtn.TabIndex = 3;
            xuatbtn.Text = "Xuất file danh sách";
            xuatbtn.UseVisualStyleBackColor = false;
            xuatbtn.Click += xuatbtn_Click;
            // 
            // timtheongayradio
            // 
            timtheongayradio.Anchor = AnchorStyles.Top;
            timtheongayradio.AutoSize = true;
            timtheongayradio.ForeColor = SystemColors.ActiveCaptionText;
            timtheongayradio.Location = new Point(632, 104);
            timtheongayradio.Name = "timtheongayradio";
            timtheongayradio.Size = new Size(191, 24);
            timtheongayradio.TabIndex = 27;
            timtheongayradio.Text = "Tìm theo ngày lập phiếu";
            timtheongayradio.UseVisualStyleBackColor = true;
            timtheongayradio.CheckedChanged += timtheongayradio_CheckedChanged;
            // 
            // ngaydtpicker
            // 
            ngaydtpicker.Location = new Point(486, 134);
            ngaydtpicker.Name = "ngaydtpicker";
            ngaydtpicker.Size = new Size(250, 27);
            ngaydtpicker.TabIndex = 28;
            // 
            // DSPHIEUSUACHUA
            // 
            AcceptButton = timkiembtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(1183, 670);
            Controls.Add(ngaydtpicker);
            Controls.Add(timtheongayradio);
            Controls.Add(xuatbtn);
            Controls.Add(thoatbtn);
            Controls.Add(xembtn);
            Controls.Add(pscdtgrid);
            Controls.Add(timkiembtn);
            Controls.Add(mapscradio);
            Controls.Add(timkiemtxtbox);
            Controls.Add(SearchLabel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DSPHIEUSUACHUA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách phiếu sửa chữa";
            Load += DSPHIEUSUACHUA_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pscdtgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label VatTuPhuTung_Title;
        private Button timkiembtn;
        private RadioButton mapscradio;
        private TextBox timkiemtxtbox;
        private Label SearchLabel;
        private Button xembtn;
        private Button thoatbtn;
        private DataGridView pscdtgrid;
        private DataGridViewTextBoxColumn MaPSC;
        private DataGridViewTextBoxColumn BienSo;
        private DataGridViewTextBoxColumn NgaySuaChua;
        private DataGridViewTextBoxColumn TongTien;
        private Button xuatbtn;
        private RadioButton timtheongayradio;
        private DateTimePicker ngaydtpicker;
    }
}