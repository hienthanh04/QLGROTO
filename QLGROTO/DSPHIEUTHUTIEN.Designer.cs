namespace QLGROTO
{
    partial class DSPHIEUTHUTIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSPHIEUTHUTIEN));
            panel1 = new Panel();
            VatTuPhuTung_Title = new Label();
            timkiembtn = new Button();
            mapttradio = new RadioButton();
            timkiemtxtbox = new TextBox();
            SearchLabel = new Label();
            pttdtgrid = new DataGridView();
            MaPTT = new DataGridViewTextBoxColumn();
            NgayThuTien = new DataGridViewTextBoxColumn();
            BienSo = new DataGridViewTextBoxColumn();
            SoTienThu = new DataGridViewTextBoxColumn();
            thoatbtn = new Button();
            xuatbtn = new Button();
            timtheongayradio = new RadioButton();
            ngaydtpicker = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pttdtgrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(VatTuPhuTung_Title);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 66);
            panel1.TabIndex = 0;
            // 
            // VatTuPhuTung_Title
            // 
            VatTuPhuTung_Title.Anchor = AnchorStyles.Top;
            VatTuPhuTung_Title.AutoSize = true;
            VatTuPhuTung_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            VatTuPhuTung_Title.ForeColor = Color.White;
            VatTuPhuTung_Title.Location = new Point(362, 11);
            VatTuPhuTung_Title.Margin = new Padding(4, 0, 4, 0);
            VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            VatTuPhuTung_Title.Size = new Size(480, 45);
            VatTuPhuTung_Title.TabIndex = 5;
            VatTuPhuTung_Title.Text = "DANH SÁCH PHIẾU THU TIỀN";
            // 
            // timkiembtn
            // 
            timkiembtn.Anchor = AnchorStyles.Top;
            timkiembtn.BackColor = SystemColors.Info;
            timkiembtn.Image = Properties.Resources.search_6699087_640__1_;
            timkiembtn.Location = new Point(795, 68);
            timkiembtn.Name = "timkiembtn";
            timkiembtn.Size = new Size(79, 27);
            timkiembtn.TabIndex = 1;
            timkiembtn.UseVisualStyleBackColor = false;
            timkiembtn.Click += SearchButton_Click;
            // 
            // mapttradio
            // 
            mapttradio.Anchor = AnchorStyles.Top;
            mapttradio.AutoSize = true;
            mapttradio.ForeColor = SystemColors.ActiveCaptionText;
            mapttradio.Location = new Point(418, 101);
            mapttradio.Name = "mapttradio";
            mapttradio.Size = new Size(209, 24);
            mapttradio.TabIndex = 2;
            mapttradio.Text = "Tìm theo mã phiếu thu tiền";
            mapttradio.UseVisualStyleBackColor = true;
            mapttradio.CheckedChanged += mapnradio_CheckedChanged;
            // 
            // timkiemtxtbox
            // 
            timkiemtxtbox.Anchor = AnchorStyles.Top;
            timkiemtxtbox.BackColor = SystemColors.HighlightText;
            timkiemtxtbox.Location = new Point(418, 68);
            timkiemtxtbox.Name = "timkiemtxtbox";
            timkiemtxtbox.Size = new Size(371, 27);
            timkiemtxtbox.TabIndex = 0;
            timkiemtxtbox.TextChanged += SearchTextbox_TextChanged;
            // 
            // SearchLabel
            // 
            SearchLabel.Anchor = AnchorStyles.Top;
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SearchLabel.ForeColor = SystemColors.ActiveCaptionText;
            SearchLabel.Location = new Point(308, 67);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(104, 28);
            SearchLabel.TabIndex = 26;
            SearchLabel.Text = "Tìm kiếm:";
            // 
            // pttdtgrid
            // 
            pttdtgrid.AllowUserToAddRows = false;
            pttdtgrid.AllowUserToDeleteRows = false;
            pttdtgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pttdtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pttdtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pttdtgrid.Columns.AddRange(new DataGridViewColumn[] { MaPTT, NgayThuTien, BienSo, SoTienThu });
            pttdtgrid.Location = new Point(12, 164);
            pttdtgrid.Name = "pttdtgrid";
            pttdtgrid.ReadOnly = true;
            pttdtgrid.RowHeadersWidth = 51;
            pttdtgrid.RowTemplate.Height = 29;
            pttdtgrid.Size = new Size(1159, 423);
            pttdtgrid.TabIndex = 6;
            pttdtgrid.TabStop = false;
            pttdtgrid.CellContentClick += pttdtgrid_CellContentClick;
            // 
            // MaPTT
            // 
            MaPTT.DataPropertyName = "MaPTT";
            MaPTT.HeaderText = "Mã phiếu thu tiền";
            MaPTT.MinimumWidth = 6;
            MaPTT.Name = "MaPTT";
            MaPTT.ReadOnly = true;
            // 
            // NgayThuTien
            // 
            NgayThuTien.DataPropertyName = "NgayThuTien";
            NgayThuTien.HeaderText = "Ngày thu tiền";
            NgayThuTien.MinimumWidth = 6;
            NgayThuTien.Name = "NgayThuTien";
            NgayThuTien.ReadOnly = true;
            // 
            // BienSo
            // 
            BienSo.DataPropertyName = "BienSo";
            BienSo.HeaderText = "Biển số";
            BienSo.MinimumWidth = 6;
            BienSo.Name = "BienSo";
            BienSo.ReadOnly = true;
            // 
            // SoTienThu
            // 
            SoTienThu.DataPropertyName = "SoTienThu";
            SoTienThu.HeaderText = "Tiền thu";
            SoTienThu.MinimumWidth = 6;
            SoTienThu.Name = "SoTienThu";
            SoTienThu.ReadOnly = true;
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
            xuatbtn.Location = new Point(437, 593);
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
            timtheongayradio.Location = new Point(633, 101);
            timtheongayradio.Name = "timtheongayradio";
            timtheongayradio.Size = new Size(191, 24);
            timtheongayradio.TabIndex = 27;
            timtheongayradio.Text = "Tìm theo ngày lập phiếu";
            timtheongayradio.UseVisualStyleBackColor = true;
            timtheongayradio.CheckedChanged += timtheongayradio_CheckedChanged;
            // 
            // ngaydtpicker
            // 
            ngaydtpicker.Location = new Point(482, 131);
            ngaydtpicker.Name = "ngaydtpicker";
            ngaydtpicker.Size = new Size(250, 27);
            ngaydtpicker.TabIndex = 29;
            // 
            // DSPHIEUTHUTIEN
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
            Controls.Add(pttdtgrid);
            Controls.Add(timkiembtn);
            Controls.Add(mapttradio);
            Controls.Add(timkiemtxtbox);
            Controls.Add(SearchLabel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DSPHIEUTHUTIEN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách phiếu thu tiền";
            Load += DSPHIEUTHUTIEN_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pttdtgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label VatTuPhuTung_Title;
        private Button timkiembtn;
        private RadioButton mapttradio;
        private TextBox timkiemtxtbox;
        private Label SearchLabel;
        private DataGridView pttdtgrid;
        private Button thoatbtn;
        private DataGridViewTextBoxColumn MaPTT;
        private DataGridViewTextBoxColumn NgayThuTien;
        private DataGridViewTextBoxColumn BienSo;
        private DataGridViewTextBoxColumn SoTienThu;
        private Button xuatbtn;
        private RadioButton timtheongayradio;
        private DateTimePicker ngaydtpicker;
    }
}