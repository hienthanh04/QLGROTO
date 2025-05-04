namespace QLGROTO
{
    partial class DSVTPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSVTPT));
            panel1 = new Panel();
            VatTuPhuTung_Title = new Label();
            theotenradio = new RadioButton();
            theomaradio = new RadioButton();
            timkiemtxtbox = new TextBox();
            label1 = new Label();
            ptdtgrid = new DataGridView();
            MaVTPT = new DataGridViewTextBoxColumn();
            TenVTPT = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            xoavtptbtn = new Button();
            suavtptbtn = new Button();
            xuatbtn = new Button();
            thoatbtn = new Button();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            sltxtbox = new TextBox();
            tenvtpttxtbox = new TextBox();
            mavtpttxtbox = new TextBox();
            groupBox1 = new GroupBox();
            dgtxtbox = new TextBox();
            label2 = new Label();
            timkiembtn = new Button();
            themtcbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptdtgrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(VatTuPhuTung_Title);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 68);
            panel1.TabIndex = 1;
            // 
            // VatTuPhuTung_Title
            // 
            VatTuPhuTung_Title.Anchor = AnchorStyles.Top;
            VatTuPhuTung_Title.AutoSize = true;
            VatTuPhuTung_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            VatTuPhuTung_Title.ForeColor = Color.White;
            VatTuPhuTung_Title.Location = new Point(313, 9);
            VatTuPhuTung_Title.Margin = new Padding(4, 0, 4, 0);
            VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            VatTuPhuTung_Title.Size = new Size(521, 45);
            VatTuPhuTung_Title.TabIndex = 2;
            VatTuPhuTung_Title.Text = "DANH SÁCH VẬT TƯ PHỤ TÙNG";
            // 
            // theotenradio
            // 
            theotenradio.Anchor = AnchorStyles.Top;
            theotenradio.AutoSize = true;
            theotenradio.ForeColor = SystemColors.ActiveCaptionText;
            theotenradio.Location = new Point(573, 107);
            theotenradio.Name = "theotenradio";
            theotenradio.Size = new Size(151, 24);
            theotenradio.TabIndex = 10;
            theotenradio.Text = "Tìm theo tên VTPT";
            theotenradio.UseVisualStyleBackColor = true;
            theotenradio.CheckedChanged += theotenradio_CheckedChanged;
            // 
            // theomaradio
            // 
            theomaradio.Anchor = AnchorStyles.Top;
            theomaradio.AutoSize = true;
            theomaradio.ForeColor = SystemColors.ActiveCaptionText;
            theomaradio.Location = new Point(397, 107);
            theomaradio.Name = "theomaradio";
            theomaradio.Size = new Size(151, 24);
            theomaradio.TabIndex = 2;
            theomaradio.Text = "Tìm theo mã VTPT";
            theomaradio.UseVisualStyleBackColor = true;
            theomaradio.CheckedChanged += theomaradio_CheckedChanged;
            // 
            // timkiemtxtbox
            // 
            timkiemtxtbox.Anchor = AnchorStyles.Top;
            timkiemtxtbox.BackColor = SystemColors.HighlightText;
            timkiemtxtbox.Location = new Point(390, 74);
            timkiemtxtbox.Name = "timkiemtxtbox";
            timkiemtxtbox.Size = new Size(371, 27);
            timkiemtxtbox.TabIndex = 0;
            timkiemtxtbox.TextChanged += timkiemtxtbox_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(280, 73);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 7;
            label1.Text = "Tìm kiếm:";
            // 
            // ptdtgrid
            // 
            ptdtgrid.AllowUserToAddRows = false;
            ptdtgrid.AllowUserToDeleteRows = false;
            ptdtgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ptdtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ptdtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ptdtgrid.Columns.AddRange(new DataGridViewColumn[] { MaVTPT, TenVTPT, SoLuongTon, DonGia });
            ptdtgrid.Location = new Point(12, 137);
            ptdtgrid.Name = "ptdtgrid";
            ptdtgrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ptdtgrid.RowHeadersWidth = 51;
            ptdtgrid.RowTemplate.Height = 29;
            ptdtgrid.ScrollBars = ScrollBars.Vertical;
            ptdtgrid.Size = new Size(1111, 436);
            ptdtgrid.TabIndex = 4;
            ptdtgrid.TabStop = false;
            ptdtgrid.CellContentClick += ptdtgrid_CellContentClick;
            ptdtgrid.SelectionChanged += ptdtgrid_SelectionChanged;
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
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá ";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // xoavtptbtn
            // 
            xoavtptbtn.Anchor = AnchorStyles.Bottom;
            xoavtptbtn.BackColor = Color.FromArgb(192, 0, 0);
            xoavtptbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xoavtptbtn.ForeColor = Color.White;
            xoavtptbtn.ImageAlign = ContentAlignment.MiddleLeft;
            xoavtptbtn.Location = new Point(569, 675);
            xoavtptbtn.Name = "xoavtptbtn";
            xoavtptbtn.Size = new Size(265, 65);
            xoavtptbtn.TabIndex = 4;
            xoavtptbtn.Text = "Xoá VTPT";
            xoavtptbtn.UseVisualStyleBackColor = false;
            xoavtptbtn.Click += xoavtptbtn_Click;
            // 
            // suavtptbtn
            // 
            suavtptbtn.Anchor = AnchorStyles.Bottom;
            suavtptbtn.BackColor = Color.Yellow;
            suavtptbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            suavtptbtn.ForeColor = Color.Black;
            suavtptbtn.ImageAlign = ContentAlignment.MiddleLeft;
            suavtptbtn.Location = new Point(292, 675);
            suavtptbtn.Name = "suavtptbtn";
            suavtptbtn.Size = new Size(265, 65);
            suavtptbtn.TabIndex = 3;
            suavtptbtn.Text = "Cập nhật VTPT";
            suavtptbtn.UseVisualStyleBackColor = false;
            suavtptbtn.Click += button10_Click;
            // 
            // xuatbtn
            // 
            xuatbtn.Anchor = AnchorStyles.Bottom;
            xuatbtn.BackColor = SystemColors.Control;
            xuatbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xuatbtn.ForeColor = SystemColors.ActiveCaptionText;
            xuatbtn.ImageAlign = ContentAlignment.MiddleLeft;
            xuatbtn.Location = new Point(858, 675);
            xuatbtn.Name = "xuatbtn";
            xuatbtn.Size = new Size(265, 65);
            xuatbtn.TabIndex = 5;
            xuatbtn.Text = "Xuất file danh sách";
            xuatbtn.UseVisualStyleBackColor = false;
            xuatbtn.Click += xuatbtn_Click;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(1000, 757);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 6;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += button2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(541, 22);
            label3.Name = "label3";
            label3.Size = new Size(151, 31);
            label3.TabIndex = 49;
            label3.Text = "Số lượng tồn:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(41, 52);
            label7.Name = "label7";
            label7.Size = new Size(111, 31);
            label7.TabIndex = 50;
            label7.Text = "Tên VTPT:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(43, 22);
            label8.Name = "label8";
            label8.Size = new Size(109, 31);
            label8.TabIndex = 51;
            label8.Text = "Mã VTPT:";
            // 
            // sltxtbox
            // 
            sltxtbox.Anchor = AnchorStyles.Bottom;
            sltxtbox.BackColor = Color.Gainsboro;
            sltxtbox.Enabled = false;
            sltxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sltxtbox.Location = new Point(698, 24);
            sltxtbox.Multiline = true;
            sltxtbox.Name = "sltxtbox";
            sltxtbox.ReadOnly = true;
            sltxtbox.ScrollBars = ScrollBars.Horizontal;
            sltxtbox.Size = new Size(360, 25);
            sltxtbox.TabIndex = 45;
            // 
            // tenvtpttxtbox
            // 
            tenvtpttxtbox.Anchor = AnchorStyles.Bottom;
            tenvtpttxtbox.BackColor = Color.Gainsboro;
            tenvtpttxtbox.Enabled = false;
            tenvtpttxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tenvtpttxtbox.Location = new Point(158, 54);
            tenvtpttxtbox.Multiline = true;
            tenvtpttxtbox.Name = "tenvtpttxtbox";
            tenvtpttxtbox.ReadOnly = true;
            tenvtpttxtbox.ScrollBars = ScrollBars.Horizontal;
            tenvtpttxtbox.Size = new Size(360, 25);
            tenvtpttxtbox.TabIndex = 46;
            // 
            // mavtpttxtbox
            // 
            mavtpttxtbox.Anchor = AnchorStyles.Bottom;
            mavtpttxtbox.BackColor = Color.Gainsboro;
            mavtpttxtbox.Enabled = false;
            mavtpttxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mavtpttxtbox.Location = new Point(158, 24);
            mavtpttxtbox.Multiline = true;
            mavtpttxtbox.Name = "mavtpttxtbox";
            mavtpttxtbox.ReadOnly = true;
            mavtpttxtbox.ScrollBars = ScrollBars.Horizontal;
            mavtpttxtbox.Size = new Size(360, 25);
            mavtpttxtbox.TabIndex = 47;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom;
            groupBox1.Controls.Add(tenvtpttxtbox);
            groupBox1.Controls.Add(mavtpttxtbox);
            groupBox1.Controls.Add(dgtxtbox);
            groupBox1.Controls.Add(sltxtbox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 579);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1111, 90);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // dgtxtbox
            // 
            dgtxtbox.Anchor = AnchorStyles.Bottom;
            dgtxtbox.BackColor = Color.Gainsboro;
            dgtxtbox.Enabled = false;
            dgtxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgtxtbox.Location = new Point(698, 52);
            dgtxtbox.Multiline = true;
            dgtxtbox.Name = "dgtxtbox";
            dgtxtbox.ReadOnly = true;
            dgtxtbox.ScrollBars = ScrollBars.Horizontal;
            dgtxtbox.Size = new Size(360, 25);
            dgtxtbox.TabIndex = 45;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(592, 50);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 49;
            label2.Text = "Đơn giá:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timkiembtn
            // 
            timkiembtn.Anchor = AnchorStyles.Top;
            timkiembtn.BackColor = SystemColors.Info;
            timkiembtn.Image = Properties.Resources.search_6699087_640__1_;
            timkiembtn.Location = new Point(767, 74);
            timkiembtn.Name = "timkiembtn";
            timkiembtn.Size = new Size(79, 27);
            timkiembtn.TabIndex = 1;
            timkiembtn.UseVisualStyleBackColor = false;
            timkiembtn.Click += timkiembtn_Click;
            // 
            // themtcbtn
            // 
            themtcbtn.Anchor = AnchorStyles.Bottom;
            themtcbtn.BackColor = Color.FromArgb(0, 192, 0);
            themtcbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            themtcbtn.ForeColor = Color.White;
            themtcbtn.ImageAlign = ContentAlignment.MiddleLeft;
            themtcbtn.Location = new Point(12, 675);
            themtcbtn.Name = "themtcbtn";
            themtcbtn.Size = new Size(265, 65);
            themtcbtn.TabIndex = 2;
            themtcbtn.Text = "Thêm VTPT";
            themtcbtn.UseVisualStyleBackColor = false;
            themtcbtn.Click += themtcbtn_Click;
            // 
            // DSVTPT
            // 
            AcceptButton = timkiembtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(1135, 814);
            Controls.Add(themtcbtn);
            Controls.Add(timkiembtn);
            Controls.Add(groupBox1);
            Controls.Add(thoatbtn);
            Controls.Add(xuatbtn);
            Controls.Add(xoavtptbtn);
            Controls.Add(suavtptbtn);
            Controls.Add(ptdtgrid);
            Controls.Add(theotenradio);
            Controls.Add(theomaradio);
            Controls.Add(timkiemtxtbox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "DSVTPT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách vật tư phụ tùng";
            Load += QUANLYVATTUPHUTUNG_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptdtgrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VatTuPhuTung_Title;
        private RadioButton theotenradio;
        private RadioButton theomaradio;
        private TextBox timkiemtxtbox;
        private Label label1;
        private DataGridView ptdtgrid;
        private Button xoavtptbtn;
        private Button suavtptbtn;
        private Button xuatbtn;
        private Button thoatbtn;
        private Label label3;
        private Label label7;
        private Label label8;
        private TextBox sltxtbox;
        private TextBox tenvtpttxtbox;
        private TextBox mavtpttxtbox;
        private GroupBox groupBox1;
        private TextBox dgtxtbox;
        private Label label2;
        private DataGridViewTextBoxColumn MaVTPT;
        private DataGridViewTextBoxColumn TenVTPT;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewTextBoxColumn DonGia;
        private Button timkiembtn;
        private Button themtcbtn;
    }
}