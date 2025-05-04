namespace QLGROTO
{
    partial class DSNHANVIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSNHANVIEN));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            VatTuPhuTung_Title = new Label();
            timkiembtn = new Button();
            tennvradiobtn = new RadioButton();
            tendnradio = new RadioButton();
            timkiemtxtbox = new TextBox();
            SearchLabel = new Label();
            nvdtgrid = new DataGridView();
            TenDangNhap = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            suanvbtn = new Button();
            xoanvbtn = new Button();
            themnvbtn = new Button();
            thoatbtn = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            TenChuXe = new Label();
            chucvutxtbox = new TextBox();
            textBox3 = new TextBox();
            dthtxtbox = new TextBox();
            emailtxtbox = new TextBox();
            tentxtbox = new TextBox();
            dctxtbox = new TextBox();
            mktxtbox = new TextBox();
            tdntxtbox = new TextBox();
            xuatbtn = new Button();
            sdtradio = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nvdtgrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(VatTuPhuTung_Title);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1406, 66);
            panel1.TabIndex = 0;
            // 
            // VatTuPhuTung_Title
            // 
            VatTuPhuTung_Title.Anchor = AnchorStyles.Top;
            VatTuPhuTung_Title.AutoSize = true;
            VatTuPhuTung_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            VatTuPhuTung_Title.ForeColor = Color.White;
            VatTuPhuTung_Title.Location = new Point(480, 9);
            VatTuPhuTung_Title.Margin = new Padding(4, 0, 4, 0);
            VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            VatTuPhuTung_Title.Size = new Size(409, 45);
            VatTuPhuTung_Title.TabIndex = 0;
            VatTuPhuTung_Title.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // timkiembtn
            // 
            timkiembtn.Anchor = AnchorStyles.Top;
            timkiembtn.BackColor = SystemColors.Info;
            timkiembtn.Image = Properties.Resources.search_6699087_640__1_;
            timkiembtn.Location = new Point(909, 70);
            timkiembtn.Name = "timkiembtn";
            timkiembtn.Size = new Size(79, 27);
            timkiembtn.TabIndex = 1;
            timkiembtn.UseVisualStyleBackColor = false;
            timkiembtn.Click += timkiembtn_Click;
            // 
            // tennvradiobtn
            // 
            tennvradiobtn.Anchor = AnchorStyles.Top;
            tennvradiobtn.AutoSize = true;
            tennvradiobtn.ForeColor = SystemColors.ActiveCaptionText;
            tennvradiobtn.Location = new Point(590, 100);
            tennvradiobtn.Name = "tennvradiobtn";
            tennvradiobtn.Size = new Size(181, 24);
            tennvradiobtn.TabIndex = 4;
            tennvradiobtn.Text = "Tìm theo tên nhân viên";
            tennvradiobtn.UseVisualStyleBackColor = true;
            tennvradiobtn.CheckedChanged += tennvradiobtn_CheckedChanged;
            // 
            // tendnradio
            // 
            tendnradio.Anchor = AnchorStyles.Top;
            tendnradio.AutoSize = true;
            tendnradio.ForeColor = SystemColors.ActiveCaptionText;
            tendnradio.Location = new Point(395, 100);
            tendnradio.Name = "tendnradio";
            tendnradio.Size = new Size(189, 24);
            tendnradio.TabIndex = 3;
            tendnradio.Text = "Tìm theo tên đăng nhập";
            tendnradio.UseVisualStyleBackColor = true;
            tendnradio.CheckedChanged += manvradio_CheckedChanged;
            // 
            // timkiemtxtbox
            // 
            timkiemtxtbox.Anchor = AnchorStyles.Top;
            timkiemtxtbox.BackColor = SystemColors.HighlightText;
            timkiemtxtbox.Location = new Point(532, 70);
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
            SearchLabel.Location = new Point(422, 69);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(104, 28);
            SearchLabel.TabIndex = 31;
            SearchLabel.Text = "Tìm kiếm:";
            // 
            // nvdtgrid
            // 
            nvdtgrid.AllowUserToAddRows = false;
            nvdtgrid.AllowUserToDeleteRows = false;
            nvdtgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nvdtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            nvdtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nvdtgrid.Columns.AddRange(new DataGridViewColumn[] { TenDangNhap, MatKhau, TenNV, DiaChi, DienThoai, Email, ChucVu });
            nvdtgrid.Location = new Point(12, 130);
            nvdtgrid.Name = "nvdtgrid";
            nvdtgrid.ReadOnly = true;
            nvdtgrid.RowHeadersWidth = 51;
            nvdtgrid.RowTemplate.Height = 29;
            nvdtgrid.Size = new Size(1380, 333);
            nvdtgrid.TabIndex = 500;
            nvdtgrid.TabStop = false;
            nvdtgrid.CellContentClick += nvdtgrid_CellContentClick;
            nvdtgrid.CellValueChanged += nvdtgrid_CellValueChanged;
            nvdtgrid.SelectionChanged += nvdtgrid_SelectionChanged;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // MatKhau
            // 
            MatKhau.DataPropertyName = "MatKhau";
            MatKhau.HeaderText = "Mật khẩu";
            MatKhau.MinimumWidth = 6;
            MatKhau.Name = "MatKhau";
            MatKhau.ReadOnly = true;
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "TenNV";
            TenNV.HeaderText = "Họ và tên ";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            TenNV.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // ChucVu
            // 
            ChucVu.DataPropertyName = "ChucVu";
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            ChucVu.ReadOnly = true;
            // 
            // suanvbtn
            // 
            suanvbtn.Anchor = AnchorStyles.Bottom;
            suanvbtn.BackColor = Color.Yellow;
            suanvbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            suanvbtn.ForeColor = SystemColors.ActiveCaptionText;
            suanvbtn.ImageAlign = ContentAlignment.MiddleLeft;
            suanvbtn.Location = new Point(370, 680);
            suanvbtn.Name = "suanvbtn";
            suanvbtn.Size = new Size(265, 65);
            suanvbtn.TabIndex = 4;
            suanvbtn.Text = "Cập nhật thông tin nhân viên";
            suanvbtn.UseVisualStyleBackColor = false;
            suanvbtn.Click += suanvbtn_Click;
            // 
            // xoanvbtn
            // 
            xoanvbtn.Anchor = AnchorStyles.Bottom;
            xoanvbtn.BackColor = Color.FromArgb(192, 0, 0);
            xoanvbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xoanvbtn.ForeColor = Color.White;
            xoanvbtn.ImageAlign = ContentAlignment.MiddleLeft;
            xoanvbtn.Location = new Point(764, 680);
            xoanvbtn.Name = "xoanvbtn";
            xoanvbtn.Size = new Size(265, 65);
            xoanvbtn.TabIndex = 5;
            xoanvbtn.Text = "Xóa nhân viên";
            xoanvbtn.UseVisualStyleBackColor = false;
            xoanvbtn.Click += xoanvbtn_Click;
            // 
            // themnvbtn
            // 
            themnvbtn.Anchor = AnchorStyles.Bottom;
            themnvbtn.BackColor = Color.FromArgb(0, 192, 0);
            themnvbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            themnvbtn.ForeColor = Color.White;
            themnvbtn.ImageAlign = ContentAlignment.MiddleLeft;
            themnvbtn.Location = new Point(12, 680);
            themnvbtn.Name = "themnvbtn";
            themnvbtn.Size = new Size(265, 65);
            themnvbtn.TabIndex = 3;
            themnvbtn.Text = "Thêm nhân viên";
            themnvbtn.UseVisualStyleBackColor = false;
            themnvbtn.Click += themtiencong_btn_Click;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = SystemColors.Control;
            thoatbtn.Location = new Point(1271, 755);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 7;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TenChuXe);
            groupBox1.Controls.Add(chucvutxtbox);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(dthtxtbox);
            groupBox1.Controls.Add(emailtxtbox);
            groupBox1.Controls.Add(tentxtbox);
            groupBox1.Controls.Add(dctxtbox);
            groupBox1.Controls.Add(mktxtbox);
            groupBox1.Controls.Add(tdntxtbox);
            groupBox1.Location = new Point(12, 469);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1380, 205);
            groupBox1.TabIndex = 72;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(522, 158);
            label3.Name = "label3";
            label3.Size = new Size(101, 31);
            label3.TabIndex = 33;
            label3.Text = "Chức vụ:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(227, 112);
            label2.Name = "label2";
            label2.Size = new Size(124, 31);
            label2.TabIndex = 34;
            label2.Text = "Điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(765, 112);
            label5.Name = "label5";
            label5.Size = new Size(75, 31);
            label5.TabIndex = 35;
            label5.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(751, 77);
            label1.Name = "label1";
            label1.Size = new Size(89, 31);
            label1.TabIndex = 35;
            label1.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(235, 77);
            label4.Name = "label4";
            label4.Size = new Size(116, 31);
            label4.TabIndex = 36;
            label4.Text = "Họ và tên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(725, 42);
            label6.Name = "label6";
            label6.Size = new Size(115, 31);
            label6.TabIndex = 36;
            label6.Text = "Mật khẩu:";
            // 
            // TenChuXe
            // 
            TenChuXe.AutoSize = true;
            TenChuXe.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TenChuXe.Location = new Point(180, 37);
            TenChuXe.Name = "TenChuXe";
            TenChuXe.Size = new Size(171, 31);
            TenChuXe.TabIndex = 36;
            TenChuXe.Text = "Tên đăng nhập:";
            // 
            // chucvutxtbox
            // 
            chucvutxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chucvutxtbox.BackColor = Color.Gainsboro;
            chucvutxtbox.Enabled = false;
            chucvutxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chucvutxtbox.Location = new Point(629, 160);
            chucvutxtbox.Multiline = true;
            chucvutxtbox.Name = "chucvutxtbox";
            chucvutxtbox.ReadOnly = true;
            chucvutxtbox.ScrollBars = ScrollBars.Horizontal;
            chucvutxtbox.Size = new Size(300, 29);
            chucvutxtbox.TabIndex = 28;
            chucvutxtbox.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(629, 160);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Horizontal;
            textBox3.Size = new Size(300, 29);
            textBox3.TabIndex = 29;
            // 
            // dthtxtbox
            // 
            dthtxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dthtxtbox.BackColor = Color.Gainsboro;
            dthtxtbox.Enabled = false;
            dthtxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dthtxtbox.Location = new Point(357, 114);
            dthtxtbox.Multiline = true;
            dthtxtbox.Name = "dthtxtbox";
            dthtxtbox.ReadOnly = true;
            dthtxtbox.ScrollBars = ScrollBars.Horizontal;
            dthtxtbox.Size = new Size(300, 29);
            dthtxtbox.TabIndex = 31;
            dthtxtbox.TabStop = false;
            // 
            // emailtxtbox
            // 
            emailtxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailtxtbox.BackColor = Color.Gainsboro;
            emailtxtbox.Enabled = false;
            emailtxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxtbox.Location = new Point(846, 114);
            emailtxtbox.Multiline = true;
            emailtxtbox.Name = "emailtxtbox";
            emailtxtbox.ReadOnly = true;
            emailtxtbox.ScrollBars = ScrollBars.Horizontal;
            emailtxtbox.Size = new Size(300, 29);
            emailtxtbox.TabIndex = 30;
            emailtxtbox.TabStop = false;
            // 
            // tentxtbox
            // 
            tentxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tentxtbox.BackColor = Color.Gainsboro;
            tentxtbox.Enabled = false;
            tentxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tentxtbox.Location = new Point(357, 79);
            tentxtbox.Multiline = true;
            tentxtbox.Name = "tentxtbox";
            tentxtbox.ReadOnly = true;
            tentxtbox.ScrollBars = ScrollBars.Horizontal;
            tentxtbox.Size = new Size(300, 29);
            tentxtbox.TabIndex = 32;
            tentxtbox.TabStop = false;
            // 
            // dctxtbox
            // 
            dctxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dctxtbox.BackColor = Color.Gainsboro;
            dctxtbox.Enabled = false;
            dctxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dctxtbox.Location = new Point(846, 79);
            dctxtbox.Multiline = true;
            dctxtbox.Name = "dctxtbox";
            dctxtbox.ReadOnly = true;
            dctxtbox.ScrollBars = ScrollBars.Horizontal;
            dctxtbox.Size = new Size(300, 29);
            dctxtbox.TabIndex = 31;
            dctxtbox.TabStop = false;
            // 
            // mktxtbox
            // 
            mktxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mktxtbox.BackColor = Color.Gainsboro;
            mktxtbox.Enabled = false;
            mktxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mktxtbox.Location = new Point(846, 44);
            mktxtbox.Multiline = true;
            mktxtbox.Name = "mktxtbox";
            mktxtbox.ReadOnly = true;
            mktxtbox.ScrollBars = ScrollBars.Horizontal;
            mktxtbox.Size = new Size(300, 29);
            mktxtbox.TabIndex = 32;
            mktxtbox.TabStop = false;
            // 
            // tdntxtbox
            // 
            tdntxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tdntxtbox.BackColor = Color.Gainsboro;
            tdntxtbox.Enabled = false;
            tdntxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tdntxtbox.Location = new Point(357, 39);
            tdntxtbox.Multiline = true;
            tdntxtbox.Name = "tdntxtbox";
            tdntxtbox.ReadOnly = true;
            tdntxtbox.ScrollBars = ScrollBars.Horizontal;
            tdntxtbox.Size = new Size(300, 29);
            tdntxtbox.TabIndex = 32;
            tdntxtbox.TabStop = false;
            // 
            // xuatbtn
            // 
            xuatbtn.Anchor = AnchorStyles.Bottom;
            xuatbtn.BackColor = SystemColors.Control;
            xuatbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xuatbtn.ForeColor = SystemColors.ActiveCaptionText;
            xuatbtn.ImageAlign = ContentAlignment.MiddleLeft;
            xuatbtn.Location = new Point(1127, 680);
            xuatbtn.Name = "xuatbtn";
            xuatbtn.Size = new Size(265, 65);
            xuatbtn.TabIndex = 6;
            xuatbtn.Text = "Xuất file danh sách";
            xuatbtn.UseVisualStyleBackColor = false;
            xuatbtn.Click += xuatbtn_Click;
            // 
            // sdtradio
            // 
            sdtradio.Anchor = AnchorStyles.Top;
            sdtradio.AutoSize = true;
            sdtradio.ForeColor = SystemColors.ActiveCaptionText;
            sdtradio.Location = new Point(777, 100);
            sdtradio.Name = "sdtradio";
            sdtradio.Size = new Size(246, 24);
            sdtradio.TabIndex = 5;
            sdtradio.Text = "Tìm theo số điện thoại nhân viên";
            sdtradio.UseVisualStyleBackColor = true;
            sdtradio.CheckedChanged += sdtradio_CheckedChanged;
            // 
            // DSNHANVIEN
            // 
            AcceptButton = timkiembtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(1404, 812);
            Controls.Add(sdtradio);
            Controls.Add(xuatbtn);
            Controls.Add(groupBox1);
            Controls.Add(thoatbtn);
            Controls.Add(suanvbtn);
            Controls.Add(xoanvbtn);
            Controls.Add(themnvbtn);
            Controls.Add(nvdtgrid);
            Controls.Add(timkiembtn);
            Controls.Add(tennvradiobtn);
            Controls.Add(tendnradio);
            Controls.Add(timkiemtxtbox);
            Controls.Add(SearchLabel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "DSNHANVIEN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách nhân viên";
            Load += DSNHANVIEN_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nvdtgrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label VatTuPhuTung_Title;
        private Button timkiembtn;
        private RadioButton tennvradiobtn;
        private RadioButton tendnradio;
        private TextBox timkiemtxtbox;
        private Label SearchLabel;
        private DataGridView nvdtgrid;
        private Button suanvbtn;
        private Button xoanvbtn;
        private Button themnvbtn;
        private Button thoatbtn;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label TenChuXe;
        private TextBox chucvutxtbox;
        private TextBox textBox3;
        private TextBox emailtxtbox;
        private TextBox dctxtbox;
        private TextBox tdntxtbox;
        private Label label5;
        private Label label4;
        private TextBox dthtxtbox;
        private TextBox tentxtbox;
        private Button xuatbtn;
        private RadioButton sdtradio;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn ChucVu;
        private Label label6;
        private TextBox mktxtbox;
    }
}